using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class ItemSO : ScriptableObject
{
    public bool isDefaultItem = false;
    public Sprite itemIcon;
    public string itemName;
}