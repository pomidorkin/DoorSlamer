using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory
{
    public bool middleBuildingPurchased { set; get; }
    public bool expensiveBuildingPurchased { set; get; }

    public int doorDamage { set; get; }

    public bool toiletPurchased { set; get; }
}
