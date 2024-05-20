using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndDoor : MonoBehaviour
{
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player") && Inventory.Instance._inventoryItems.Count == 3)
        {
            SceneManager.LoadScene("End");
        }
    }
}
