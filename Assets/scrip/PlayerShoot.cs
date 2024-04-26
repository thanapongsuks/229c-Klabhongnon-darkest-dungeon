using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject target;
    [SerializeField] private Rigidbody2D bulletPrefabs;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.DrawRay(ray.origin, ray.direction * 10f, Color.green, 10f);

            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);

            if (hit.collider != null)
            {
                target.transform.position = hit.point;
                Debug.Log($"hit point : ({hit.point.x}, {hit.point.y})");

                Vector2 distance = hit.point - (Vector2)shootPoint.position; // Corrected subtraction
                Vector2 projectileVelocity = distance / 0.25f; // Assuming time is always 1f
                projectileVelocity.y += 0.1f * Mathf.Abs(Physics2D.gravity.y); // Apply gravity

                Rigidbody2D fired = Instantiate(bulletPrefabs, shootPoint.position, Quaternion.identity);
                fired.velocity = projectileVelocity;
            }
        }
    }
}
