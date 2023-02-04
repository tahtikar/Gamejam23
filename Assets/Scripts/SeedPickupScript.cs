using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeedPickupScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            playerInventory.CollectSeed();
            gameObject.SetActive(false);
        }
    }
}
