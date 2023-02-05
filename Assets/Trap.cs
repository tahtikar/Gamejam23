using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{

    public int reactTrapId;
    private bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActivateTrap(int triggerId)
    {
        Debug.Log("THIS IS TRAP DO YOU HEAR TRIGGER");
        if (reactTrapId == triggerId)
        {
            Debug.Log("Do something quick!!");
            triggered = true;
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (triggered)
        {
            Rigidbody rigidBody = other.gameObject.GetComponent<Rigidbody>();
            bool isBolder = other.gameObject.CompareTag("Bolder");

            Debug.Log("OnTriggerStay is bolder: " + isBolder);
            if (rigidBody != null)
            {
                Vector3 speedNormalV = new Vector3();
                Debug.Log("speedNormalV: " + speedNormalV);
                speedNormalV.x = -1.00f;
                speedNormalV.y = 0.00f;
                speedNormalV.z = 0.00f;
                Debug.Log("speedNormalV: " + speedNormalV);


                rigidBody.AddForce(speedNormalV * 10.0f);
            }
        }
        
    }
}
