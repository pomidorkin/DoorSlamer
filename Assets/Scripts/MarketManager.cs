using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MarketManager : MonoBehaviour
{
    [SerializeField] int builgindHealthUpgradeValue = 20;
    [SerializeField] int doorDamageUpgradeValue = 10;
    [SerializeField] int middleBuildingPrice = 100;
    [SerializeField] int expensiveBuildingPrice = 100;
    [SerializeField] int healthUpgradePrice = 100;
    [SerializeField] int doorDamageUpgradegPrice = 20; //gems
    [SerializeField] int specialSlotPrice = 100;
    [SerializeField] int toiletSlotPrice = 100; // gems

    // Pop Ups
    [SerializeField] GameObject marketMenu;
    [SerializeField] GameObject footer;

    // Buttons
    [SerializeField] Button buyMiddleButton;
    [SerializeField] Button buyExpensiveButton;
    [SerializeField] Button buySpecialSlotButton;
    [SerializeField] Button buyToiletSlotButton;

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
        if (saveManager.State.expensiveBuildingPurchased)
        {
            buyExpensiveButton.interactable = false;
        }
        if (saveManager.State.speacialBuildigPurchased)
        {
            buySpecialSlotButton.interactable = false;
        }
        if (saveManager.State.toiletPurchased)
        {
            buyToiletSlotButton.interactable = false;
        }
    }

    public void OpenMarketMenu(bool isOpen)
    {
        marketMenu.gameObject.SetActive(isOpen);
        footer.gameObject.SetActive(!isOpen);
    }

    public void BuyMiddleBuilding()
    {
        if ((saveManager.State.coins - middleBuildingPrice) >= 0)
        {
            saveManager.State.coins -= middleBuildingPrice;
            saveManager.State.middleBuildingPurchased = true;
            SaveManager.Instance.Save();
            buyMiddleButton.interactable = false;
        }
            
    }

    public void BuyExpensiveBuilding()
    {
        if ((saveManager.State.coins - expensiveBuildingPrice) >= 0)
        {
            saveManager.State.coins -= expensiveBuildingPrice;
            saveManager.State.expensiveBuildingPurchased = true;
            SaveManager.Instance.Save();
            buyExpensiveButton.interactable = false;
        }

    }

    public void UpgradeBuildingHealth()
    {
        if ((saveManager.State.coins - healthUpgradePrice) >= 0)
        {
            saveManager.State.coins -= healthUpgradePrice;
            saveManager.State.buildingHealth += builgindHealthUpgradeValue;
            SaveManager.Instance.Save();
        }
        else
        {
            // Not enough money pop up
        }
    }
    public void UpgradeDoorDamage()
    {
        if ((saveManager.State.gems - doorDamageUpgradegPrice) >= 0)
        {
            saveManager.State.coins -= doorDamageUpgradegPrice;
            saveManager.State.doorDamage += doorDamageUpgradeValue;
            SaveManager.Instance.Save();
            Debug.Log("doorDamage: " + saveManager.State.doorDamage);
        }
        else
        {
            // Not enough money pop up
        }
    }

    public void BuySpecialBuildingSlot()
    {
        if ((saveManager.State.coins - specialSlotPrice) >= 0)
        {
            saveManager.State.coins -= specialSlotPrice;
            saveManager.State.speacialBuildigPurchased = true;
            buySpecialSlotButton.interactable = false;
            SaveManager.Instance.Save();
            Debug.Log(saveManager.State.coins);
        }
        else
        {
            // Not enough money pop up
        }
        Debug.Log(saveManager.State.coins);
    }

    public void BuyToiletingSlot()
    {
        if ((saveManager.State.gems - toiletSlotPrice) >= 0)
        {
            saveManager.State.gems -= toiletSlotPrice;
            saveManager.State.toiletPurchased = true;
            buyToiletSlotButton.interactable = false;
            SaveManager.Instance.Save();
            Debug.Log(saveManager.State.gems);
        }
        else
        {
            // Not enough money pop up
        }
        Debug.Log(saveManager.State.coins);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
