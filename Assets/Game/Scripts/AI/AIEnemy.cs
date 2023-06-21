using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIEnemy : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 3f;
    public float attackRange = 1f;
    public int damage = 1;
    public float attackCooldown = 2f;

    private float attackTimer;

    private void Start()
    {
        attackTimer = attackCooldown;
    }

    private void Update()
    {
        
        if (target != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

            if (Vector3.Distance(transform.position, target.position) < attackRange)
            {
                if(attackTimer >= attackCooldown)
                {
                    
                }
                else
                {
                    attackTimer += Time.deltaTime;
                }
            }
        }

    }
    
    private void Attack() // add logic
    {
        target.GetComponent<PlayerHealth>().TakeDamage(damage);
    }
}
