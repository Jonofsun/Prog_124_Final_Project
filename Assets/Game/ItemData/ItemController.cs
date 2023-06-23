using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public Item item;

    public void RemoveItem()
    {
        InventoryManager.Instance.Remove(item);
        Destroy(gameObject);
    }
    public void AddItem(Item newItem)
    {
        item = newItem;
    }
    public void UseItem()
    {

        
        //switch (item.itemName)
        //{
        //    case Item.ItemType.Potion:
        //        Player.Instance.IncreaseHealth(item.value);
        //        break;
        //    case Item.ItemType.Book:
        //        Player.Instance.IncreaseExp(item.value);
        //        break;
        //    default:
        //        break;
        //}
        //RemoveItem();
    }
}
