using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBack : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("ITS PLAYER");
            StarterAssets.ThirdPersonController tpc = other.GetComponent<StarterAssets.ThirdPersonController>();
            tpc.resetPlayer();
        }
    }
}
