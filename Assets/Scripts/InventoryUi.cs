using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUi : MonoBehaviour
{
    private TextMeshProUGUI selectedSeedTypeText;
    private TextMeshProUGUI selectedSeedCountText;
    // Start is called before the first frame update
    void Start()
    {
        selectedSeedTypeText = GameObject.Find("selectedSeedTypeText").GetComponent<TextMeshProUGUI>();
        selectedSeedCountText = GameObject.Find("selectedSeedCountText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    public void UpdateselectedSeedTypeText(PlayerInventory playerInventory)
    {
        selectedSeedTypeText.text = playerInventory.selectedSeedType;
    }
    public void UpdateselectedSeedCountText(PlayerInventory playerInventory)
    {
        selectedSeedCountText.text = playerInventory.GetSelectedSeedCount(playerInventory.selectedSeedType).ToString();
    }
}
