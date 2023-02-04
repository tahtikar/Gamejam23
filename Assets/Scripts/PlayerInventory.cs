using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int seeds { get; private set; }

    public void CollectSeed()
    {
        seeds++;
    }
    public void PlantSeed()
    {
        seeds--;
    }
}
