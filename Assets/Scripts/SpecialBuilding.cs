using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpecialBuilding : MonoBehaviour
{
    [SerializeField] GameObject weaponPrefab; // Лист вякого мусора, который будет скидываться на зомби
    [SerializeField] GameObject specialBuildingPrefab;
    [SerializeField] GameObject doorPrefab;
    [SerializeField] Button spawnSpecialButton;
    SaveManager saveManager;
    private bool spawned = false;

    private void Start()
    {
        // Проверить куплен ли слот, если да, то делаем кнопку постройки здания видимойвидимой
        saveManager = SaveManager.Instance;
        SaveManager.Instance.Load();
        //SpawnBuilding(saveManager);
        ActivateButton(saveManager);
        
    }

    private void SpawnDoor()
    {
        Instantiate(doorPrefab, this.transform.position, Quaternion.identity);
    }

    private void ActivateButton(SaveManager saveManager)
    {
        if (saveManager.State.speacialBuildigPurchased)
        {
            spawnSpecialButton.gameObject.SetActive(true);
        }

    }

    public void SpawnBuilding()
    {
        Instantiate(specialBuildingPrefab, this.transform.position, Quaternion.identity);
        SpawnDoor();
        spawned = true;
        spawnSpecialButton.interactable = false;
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && spawned)
        {
            Attack();
        }
    }

    private void Attack()
    {
        GameObject barrel;
        barrel = Instantiate(weaponPrefab, new Vector3(-21.9f, 2.75f, 1.6f), Quaternion.Euler(0, 0, 90f));
        Destroy(barrel, 2f);


    }
}
