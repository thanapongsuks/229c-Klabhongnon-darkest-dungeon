using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject target;
    [SerializeField] private Rigidbody2D bulletPrefab;
    [SerializeField] private float bulletLifetime = 3f; // Lifetime of the bullet

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
                Debug.Log($"Hit point : ({hit.point.x}, {hit.point.y})");

                Vector2 distance = hit.point - (Vector2)shootPoint.position;
                Vector2 projectileVelocity = distance / 0.25f;
                projectileVelocity.y += 0.25f * Mathf.Abs(Physics2D.gravity.y);

                Rigidbody2D fired = Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);
                fired.velocity = projectileVelocity;

                // Destroy the bullet after a certain amount of time
                Destroy(fired.gameObject, bulletLifetime);
            }
        }
    }
}



