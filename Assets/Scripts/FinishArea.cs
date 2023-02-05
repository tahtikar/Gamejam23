using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishArea : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        StarterAssets.ThirdPersonController tpc = other.GetComponent<StarterAssets.ThirdPersonController>();

        if (tpc != null && tpc.CanFinish())
        {
            GameObject finishScreen = transform.GetChild(0).GetChild(0).gameObject;
            finishScreen.SetActive(true);
        }
    }
}

