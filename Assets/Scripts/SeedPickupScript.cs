using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPickupScript : MonoBehaviour
{
    public string type;
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.CollectSeed(type);
            gameObject.SetActive(false);
        }
    }
}
