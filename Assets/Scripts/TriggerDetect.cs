using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDetect : MonoBehaviour
{
    public int triggerId;
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
            GameObject[] traps = GameObject.FindGameObjectsWithTag("Trap");

            foreach(GameObject trap in traps)
            {
                Trap script = trap.GetComponent<Trap>();
                script.ActivateTrap(triggerId);
            }

        }
    }
}
