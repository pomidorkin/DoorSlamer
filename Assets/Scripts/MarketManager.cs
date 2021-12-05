using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MarketManager : MonoBehaviour
{
    [SerializeField] Button buyMiddleButton;
    [SerializeField] int builgindHealthUpgradeValue = 20;
    [SerializeField] int doorDamageUpgradeValue = 10;
    [SerializeField] int middleBuildingPrice = 100;
    [SerializeField] int expensiveBuildingPrice = 100;
    [SerializeField] int healthUpgradePrice = 100;
    [SerializeField] int doorDamageUpgradegPrice = 20; //gems
    [SerializeField] int specialSlotPrice = 100;
    [SerializeField] int toiletSlotPrice = 100; // gems
    SaveManager saveManager;
    // Start is called before the first frame update
    void Start()
    {
        saveManager = SaveManager.Instance;
        SaveManager.Instance.Load();
        if (saveManager.State.middleBuildingPurchased)
        {
            buyMiddleButton.interactable = false;
        }
    }

    public void BuyMiddleBuilding()
    {
        // TODO: Balance check, reduce money
        saveManager.State.middleBuildingPurchased = true;
        SaveManager.Instance.Save();
        buyMiddleButton.interactable = false;
    }

    public void UpgradeBuildingHealth()
    {
        saveManager.State.buildingHealth += builgindHealthUpgradeValue;
        SaveManager.Instance.Save();
    }
    public void UpgradeDoorDamage()
    {
        saveManager.State.doorDamage += doorDamageUpgradeValue;
        SaveManager.Instance.Save();
        Debug.Log("doorDamage: " + saveManager.State.doorDamage);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
