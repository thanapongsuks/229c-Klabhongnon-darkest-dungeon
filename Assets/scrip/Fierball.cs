using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    [SerializeField] private LayerMask whatDestroyFireball;

    [SerializeField] private float fireballDamage = 1f; // Corrected variable name and specified type.

    private void Start()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision) // Corrected parameter name
    {
        if ((whatDestroyFireball.value & (1 << collision.gameObject.layer)) > 0)
        {
            IDamageable iDamageable = collision.gameObject.GetComponent<IDamageable>();
            if (iDamageable != null)
            {
                iDamageable.Damage(fireballDamage); // Pass the damage value to the Damage method.
            }
            
            Destroy(gameObject);
        }
    }
}
