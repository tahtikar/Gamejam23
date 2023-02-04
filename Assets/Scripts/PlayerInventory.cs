using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public int trampolineSeeds { get; private set; }
    public int pushSeeds { get; private set; }
    public string selectedSeedType;

    public void SetSelectedSeedType(string type)
    {
        selectedSeedType = type;
    }
    public int GetSelectedSeedCount(string type)
    {
        switch (type)
        {
            case "trampoline":
                return trampolineSeeds;
            case "push":
                return pushSeeds;
            default:
                return 0;
        }
    }

    public void CollectSeed(string type)
    {
        switch (type)
        {
            case "trampoline":
                trampolineSeeds++;
                break;
            case "push":
                pushSeeds++;
                break;
            default:
                break;
        }

    }
    public void PlantSeed(string type)
    {
        switch (type)
        {
            case "trampoline":
                trampolineSeeds--;
                break;
            case "push":
                pushSeeds--;
                break;
            default:
                break;
        }
    }
}
