using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glider : MonoBehaviour
{
    private float originalGravity;
    private float timer = 30.0f;
    private bool timerActive = false;
    private StarterAssets.ThirdPersonController tpc;
    private Material m_Material;
    private Color orig = Color.white;
    private Collider o;


    private void OnTriggerExit(Collider other)
    {
        o = other;
        tpc = other.GetComponent<StarterAssets.ThirdPersonController>();

        if (tpc != null)
        {
            originalGravity = tpc.Gravity;
            tpc.SetGravity(-1.5f);

        }
        timer = 10.0f;
        timerActive =true;
        m_Material = other.transform.GetChild(1).GetChild(0).GetComponent<Renderer>().materials[0];
        orig = m_Material.color;
        m_Material.color = Color.yellow;
    }
    private void Update()
    {
        if (timerActive && tpc != null)
        {
            timer = timer - Time.deltaTime;
            if (timer < 0)
            {

                if (tpc != null && o != null)
                {
                    tpc.SetGravity(originalGravity);
                    m_Material = o.transform.GetChild(1).GetChild(0).GetComponent<Renderer>().materials[0];
                    m_Material.color = orig;
                }
                timerActive = false;
            }
        }
    }
}