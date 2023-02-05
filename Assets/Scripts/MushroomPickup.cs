using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomPickup : MonoBehaviour
{
    public string type;
    private void OnTriggerEnter(Collider other)
    {
        StarterAssets.ThirdPersonController tpc = other.GetComponent<StarterAssets.ThirdPersonController>();

        if (tpc != null)
        {
            tpc.pickShroom();
            gameObject.SetActive(false);
        }
    }
}
