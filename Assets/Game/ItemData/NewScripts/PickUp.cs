using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private InventoryController inventory;
    public GameObject itemButton;
    public string itemName;

    private void Start()
    {
        inventory = FindObjectOfType<InventoryController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.Slots.Length; i++)
            {
                if (inventory.isFull[i] == true && inventory.Slots[i].transform.GetComponent<Slot>().amount < 2)
                {
                    if (itemName == inventory.Slots[i].transform.GetComponentInChildren<Spawn>().itemName) // stack
                    {
                        Destroy(gameObject);
                        inventory.Slots[i].GetComponent<Slot>().amount += 1;
                        break;
                    }
                }
                else if (inventory.isFull[i] == false)
                {
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.Slots[i].transform, false);
                    inventory.Slots[i].GetComponent<Slot>().amount += 1;
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
