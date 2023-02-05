using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchTrap : MonoBehaviour
{
    int reactTrapId;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateTrap(int triggerId)
    {
        if(reactTrapId == triggerId)
        {
            Debug.Log("Do something quick!!");
        }
    }
}
