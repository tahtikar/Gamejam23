using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    public int trampolineSeeds { get; private set; }
    public int pushSeeds { get; private set; }
    public string selectedSeedType;
    public GameObject trampolinePrefab;
    public GameObject pushPrefab;
    public GameObject glidePrefab;

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
    public void PlantSeed(string type, Vector3 pos, Quaternion rot)
    {
        switch (type)
        {
            case "trampoline":
                trampolineSeeds--;
                Instantiate(trampolinePrefab, pos, rot);
                break;
            case "push":
                pushSeeds--;
                Instantiate(pushPrefab, pos, rot);
                break;
            case "glide":
                pushSeeds--;
                Instantiate(glidePrefab, pos, rot);
                break;
            default:
                break;
        }
    }
}
