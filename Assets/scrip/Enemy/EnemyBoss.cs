using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBoss : MonoBehaviour, IDamageable
{
    [SerializeField] float health, maxHealth = 10f;
    
    private float currentHP;
    [SerializeField] HealthBar healthBar;

    private void Awake()
    {
        //healthBar = GetComponentInChildren<HealthBar>();
    }

    private void Start()
    {
        health = maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
    }

    public void Damage(float damageAmount)
    {
        health -= damageAmount;
        
        //currentHP -= damageAmount;
        healthBar.UpdateHealthBar(health, maxHealth);

        if (health <= 0)
        {
            SceneManager.LoadScene("WIN");
            Destroy(gameObject);
        }

    }
}
