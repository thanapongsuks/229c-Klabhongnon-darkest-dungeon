using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fierball : MonoBehaviour
{
    [SerializeField] private LayerMask whatDestroyFierball;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collisiion)
    {
        if ((whatDestroyFierball.value & (1 << collisiion.gameObject.layer)) > 0)
        {
            Destroy(gameObject);
        }
    }
}