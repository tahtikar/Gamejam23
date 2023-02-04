using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideInHierarchy : MonoBehaviour
{
    // Start is called before the first frame update
        void Start()
    {
        for (int i = 0; i < 4; i++)
        {
            GameObject createdGO = GameObject.CreatePrimitive(PrimitiveType.Plane);
            createdGO.hideFlags = HideFlags.HideInHierarchy;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
