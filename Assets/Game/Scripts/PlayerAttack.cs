using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [Header("Keybinds")]
    public KeyCode mouseButton = KeyCode.Mouse1;
    public int damageAmount = 10; // Amount of damage the player's attack deals

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            // Perform attack logic when the left mouse button is clicked
            Attack();
        }
    }

    private void Attack()
    {
        // Raycast from the mouse position to detect if an enemy is hit
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Check if the object hit is an enemy
            EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
            if (enemyHealth != null)
            {
                // Deal damage to the enemy
                enemyHealth.TakeDamage(damageAmount);
            }
        }
    }
}
