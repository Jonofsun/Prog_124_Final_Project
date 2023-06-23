using UnityEngine;
[CreateAssetMenu(fileName ="New Item",menuName = "Item/Create new Item")]
public class Item : ScriptableObject
{
    public int id;
    public string itemName;
    public int value;
    public Sprite icon;

    public ItemType itemtype;

    public enum ItemType
    {
        Potion,
        Book
    }
}
