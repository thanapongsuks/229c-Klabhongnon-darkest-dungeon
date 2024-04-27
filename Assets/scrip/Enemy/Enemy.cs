using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float HP, maxHP = 5f;

    private void Start()
    {
        HP = maxHP;
    }

    public void TakeDamage(float damageAmount)
    {
        HP -= damageAmount; // 5-4-3-2-1 = die

        if (HP <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
