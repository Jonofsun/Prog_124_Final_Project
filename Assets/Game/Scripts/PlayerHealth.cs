using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    private bool isDead;

    void Start()
    {
        currentHealth = maxHealth;
        isDead = false;
    }

    public void Heal(int healAmount)
    {
        currentHealth += healAmount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
    }
    public void TakeDamage(int damageAmount)
    {
        if (isDead == false)
        {
            currentHealth -= damageAmount;


        }
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
            
        }
    }
    private void Die()
    {
        isDead = true;
    }
}
