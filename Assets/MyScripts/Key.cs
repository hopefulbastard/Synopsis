using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] Inventory.AllItems _itemType;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory.Instance.AddItem(_itemType);
            Destroy(gameObject);
        }
    }
}
