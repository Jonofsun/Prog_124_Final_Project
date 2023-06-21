using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{
    public int health;
    public int damage;
    public int level;

    public virtual void Attack()
    {
        // Logic for enemy attack
    }

    public virtual void TakeDamage(int damageAmount)
    {
        // Logic for enemy taking damage
    }

    public virtual void Die()
    {
        // Logic for enemy death
    }
}
// Goblin Enemy
public class GoblinEnemy : BaseEnemy
{
    // Additional properties and methods specific to goblins
}

// Skeleton Enemy
public class SkeletonEnemy : BaseEnemy
{
    // Additional properties and methods specific to skeletons
}

// Dragon Enemy
public class DragonEnemy : BaseEnemy
{
    // Additional properties and methods specific to dragons
}
