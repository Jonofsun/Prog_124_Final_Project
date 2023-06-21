using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health of the enemy
    public int currentHealth; // Current health of the enemy

    private bool isDead; // Flag to track enemy's death

    private void Start()
    {
        currentHealth = maxHealth; // Initialize the current health
        isDead = false; // Initialize the death flag
    }

    public void TakeDamage(int damageAmount)
    {
        if (isDead)
            return;

        currentHealth -= damageAmount;

        // Check if the enemy is dead
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Die();
        }

        // Perform any additional actions or effects on the enemy when taking damage
    }

    private void Die()
    {
        isDead = true;

        // Perform actions when the enemy dies, such as playing death animations, triggering events, or removing the enemy object
    }
}
