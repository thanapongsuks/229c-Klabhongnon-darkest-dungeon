using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private float maxHP = 5f;

    private float currentHP;

    private void Start()
    {
        currentHP = maxHP;
    }

    public void Damage(float damageAmount)
    {
        currentHP -= damageAmount;
        if (currentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
