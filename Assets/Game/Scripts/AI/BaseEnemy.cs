using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public int health = 10;
    public int level = 1;

    public Transform target;
    private UnityEngine.AI.NavMeshAgent agent;
    public float moveSpeed = 3f;
    public float attackRange = 1f;
    public int damage = 1;
    public float attackCooldown = 2f;

    public bool isDead;


    public float attackTimer;

    public GameObject potionPrefab;

    private void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        attackTimer = attackCooldown; // Initialize the attack timer
    }

    public void Update()
    {
        
        //if (target != null)
        //{
        //    transform.LookAt(target);
        //    // Move towards the target

        //    //transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        //    transform.position += moveSpeed * Time.deltaTime * transform.forward;
        //    // Check if the enemy is within attack range
        //    if (Vector3.Distance(transform.position, target.position) <= attackRange)
        //    {
                
        //        // Attack the target if attack cooldown has elapsed
        //        if (attackTimer >= attackCooldown)
        //        {
        //            Attack();
        //            attackTimer = 0f; // Reset the attack timer
        //        }
        //        else
        //        {
        //            attackTimer += Time.deltaTime; // Increment the attack timer
        //        }
        //    }
        //}
        
    }
    private void Attack()
    {
        // Perform attack logic here
        // Example: Deal damage to the target
        target.GetComponent<PlayerHealth>().TakeDamage(damage);
    }

    public virtual void TakeDamage(int damageAmount)
    {
        if (isDead)
            return;

        health -= damageAmount;

        // Check if the Enemy is dead
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    public virtual void Die()
    {
        isDead = true;
        if (potionPrefab != null)
        {

            Instantiate(potionPrefab, transform.position, Quaternion.identity);
        }
    }
}
// add EmenyHealth here as an inherited class
// Goblin Enemy
public class GoblinEnemy : BaseEnemy
{
    // Additional properties and methods specific to goblins
}

// Skeleton Enemy
public class SkeletonEnemy : BaseEnemy
{
     
}

// Dragon Enemy
public class DragonEnemy : BaseEnemy
{
    // Additional properties and methods specific to dragons
}
