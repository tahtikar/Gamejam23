using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolder : MonoBehaviour
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
        Rigidbody rb = gameObject.GetComponent < Rigidbody >();
        float magnitude = rb.velocity.magnitude;

        Debug.Log("OnTriggerEnter magnitude: " + magnitude);
        if (magnitude > 3.0f)
        {
            Debug.Log("OnTriggerEnter hit hard enough: ");
            Debug.Log("OnTriggerEnter hit hard enough: "+ other.gameObject.tag);
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("OnTriggerEnter Player HIT");
                StarterAssets.ThirdPersonController tpc = other.GetComponent<StarterAssets.ThirdPersonController>();
                tpc.resetPlayer();
            }
        }
        
    }
}
