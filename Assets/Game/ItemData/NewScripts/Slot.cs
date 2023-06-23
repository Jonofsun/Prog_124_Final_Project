using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Slot : MonoBehaviour
{
    private InventoryController inventory;
    public int i;
    public TextMeshProUGUI amountText;
    public int amount;

    private void Start()
    {
        inventory = FindObjectOfType<InventoryController>();
    }
    private void Update()
    {
        amountText.text = amount.ToString();
        if (transform.childCount == 2)
        {
            inventory.isFull[i] = false;
        }
    }
}
