using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    public int coins { set; get; }
    public int gems { set; get; }

    public bool middleBuildingPurchased { set; get; }
    public bool expensiveBuildingPurchased { set; get; }

    public int doorDamage { set; get; }
    public int buildingHealth { set; get; }

    public bool toiletPurchased { set; get; }
    public bool speacialBuildigPurchased { set; get; }
}
