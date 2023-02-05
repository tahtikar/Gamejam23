using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampolineController : MonoBehaviour
{
    private float originalJumpHeight;
    private Material m_Material;
    private Color orig = Color.white;

    private void OnTriggerEnter(Collider other)
    {
        StarterAssets.ThirdPersonController tpc = other.GetComponent<StarterAssets.ThirdPersonController>();

        if (tpc != null)
        {
            originalJumpHeight = tpc.JumpHeight;
            tpc.SetJumpHeight(10.0f);
        }
        m_Material = other.transform.GetChild(1).GetChild(0).GetComponent<Renderer>().materials[0];
        orig = m_Material.color;
        m_Material.color = Color.blue;
    }
    private void OnTriggerExit(Collider other)
    {
        StarterAssets.ThirdPersonController tpc = other.GetComponent<StarterAssets.ThirdPersonController>();

        if (tpc != null)
        {
            tpc.SetJumpHeight(originalJumpHeight);
            m_Material = other.transform.GetChild(1).GetChild(0).GetComponent<Renderer>().materials[0];
            m_Material.color = orig;
        }
    }
}