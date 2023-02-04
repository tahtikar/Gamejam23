using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineController : MonoBehaviour
{
    private float originalJumpHeight;

    private void OnTriggerEnter(Collider other)
    {
        StarterAssets.ThirdPersonController tpc = other.GetComponent<StarterAssets.ThirdPersonController>();

        if (tpc != null)
        {
            originalJumpHeight = tpc.JumpHeight;
            tpc.SetJumpHeight(10.0f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        StarterAssets.ThirdPersonController tpc = other.GetComponent<StarterAssets.ThirdPersonController>();

        if (tpc != null)
        {
            tpc.SetJumpHeight(originalJumpHeight);
        }
    }
}