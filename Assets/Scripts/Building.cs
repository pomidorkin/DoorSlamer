using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    [SerializeField] GameObject cheapBuildingPrefab;
    [SerializeField] GameObject middleBuildingPrefab;
    [SerializeField] GameObject expensiveBuildingPrefab;
    [SerializeField] GameObject doorPrefab;
    SaveManager saveManager;
    //[SerializeField] DoorController doorObject;
    void Start()
    {
        saveManager = SaveManager.Instance;
        SaveManager.Instance.Load();
        SpawnBuilding(saveManager);
        SpawnDoor();
    }

    private void SpawnDoor()
    {
        Instantiate(doorPrefab, this.transform.position, Quaternion.identity);
    }

    private void SpawnBuilding(SaveManager saveManager)
    {
        if (!saveManager.State.middleBuildingPurchased && !saveManager.State.expensiveBuildingPurchased)
        {
            Instantiate(cheapBuildingPrefab, this.transform.position, Quaternion.identity);
        }
        else if (!saveManager.State.middleBuildingPurchased)
        {
            Instantiate(expensiveBuildingPrefab, this.transform.position, Quaternion.identity);
        }
        else
        {
            Instantiate(middleBuildingPrefab, this.transform.position, Quaternion.identity);
        }
    }
}
