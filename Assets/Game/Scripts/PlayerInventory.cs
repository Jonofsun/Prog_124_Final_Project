using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static BaseItem;

public class PlayerInventory : MonoBehaviour
{
    private PlayerHealth playerHealth; // Reference to the PlayerHealth script attached to the player
    private const int MaxPotionCount = 10; // Maximum number of potions the player can carry
    private int currentPotionCount; // Current number of potions the player has

    private void Start()
    {
        playerHealth = GetComponent<PlayerHealth>(); // Get the PlayerHealth component from the player
        currentPotionCount = 0; // Initialize the potion count
    }

    private void OnTriggerEnter(Collider other)
    {
        Potion potion = other.GetComponent<Potion>(); // Check if the collided object is a potion

        if (potion != null)
        {
            if (currentPotionCount < MaxPotionCount)
            {
                // Increment the potion count and destroy the potion object
                currentPotionCount++;
                Destroy(potion.gameObject);

                // Heal the player
                playerHealth.Heal(potion.healingAmount);
            }
            else
            {
                Debug.Log("Cannot carry more potions.");
            }
        }
    }
}
