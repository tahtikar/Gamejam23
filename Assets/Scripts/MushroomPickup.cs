using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomPickup : MonoBehaviour
{
    public string type;
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null)
        {
            gameObject.SetActive(false);
        }
    }
}
