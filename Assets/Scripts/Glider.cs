using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glider : MonoBehaviour
{
    private float originalGravity;
    private float timer = 30.0f;
    private bool timerActive = false;
    private StarterAssets.ThirdPersonController tpc;


    private void OnTriggerExit(Collider other)
    {
        tpc = other.GetComponent<StarterAssets.ThirdPersonController>();

        if (tpc != null)
        {
            originalGravity = tpc.Gravity;
            tpc.SetGravity(-1.5f);

        }
        timer = 3000.0f;
        timerActive =true;
    }
    private void Update()
    {
        if (timerActive && tpc != null)
        {
            timer = timer - Time.deltaTime;
            if (timer < 0)
            {

                if (tpc != null)
                {
                    tpc.SetGravity(originalGravity);
                }
                timerActive = false;
            }
        }
    }
}