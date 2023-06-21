using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : MonoBehaviour
{
    public string itemName;
    public string description;
    public float weight;

    public virtual void Use()
    {
        // Logic for using the item
    }
    // Consumables
    public class Potion : BaseItem
    {
        // Additional properties and methods specific to potions
    }

    public class Food : BaseItem
    {
        // Additional properties and methods specific to food items
    }

    // Weapons
    public class Sword : BaseItem
    {
        // Additional properties and methods specific to swords
    }

    public class Bow : BaseItem
    {
        // Additional properties and methods specific to bows
    }

    // Armor
    public class Helmet : BaseItem
    {
        // Additional properties and methods specific to helmets
    }

    public class Shield : BaseItem
    {
        // Additional properties and methods specific to shields
    }
}
