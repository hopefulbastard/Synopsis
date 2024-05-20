using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory Instance;

    public List<AllItems> _inventoryItems = new List<AllItems>();

    private void Awake()
    {
        Instance = this;
    }

    public void AddItem(AllItems item)
    {
        _inventoryItems.Add(item);
    }

    public enum AllItems
    {
        Key1,
        Key2,
        Key3
    }
}
