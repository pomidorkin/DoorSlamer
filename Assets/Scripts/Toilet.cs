using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toilet : MonoBehaviour
{
    [SerializeField] GameObject toiletPrefab;
    [SerializeField] GameObject doorPrefab;
    [SerializeField] Button spawnToiletButton;
    private bool spawned = false;
    // Start is called before the first frame update
    void Start()
    {
        var saveManager = SaveManager.Instance;
        SaveManager.Instance.Load();
        ActivateButton(saveManager);
    }

    private void ActivateButton(SaveManager saveManager)
    {
        if (/*saveManager.State.toiletPurchased*/ true)
        {
            spawnToiletButton.gameObject.SetActive(true);
        }

    }

    public void SpawnToilet()
    {
        Instantiate(toiletPrefab, this.transform.position, Quaternion.identity);
        SpawnDoor();
        spawned = true;
        spawnToiletButton.interactable = false;
    }

    private void SpawnDoor()
    {
        Instantiate(doorPrefab, this.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && spawned)
        {
            Attack();
        }
    }

    private void Attack()
    {
        // Выпускать облако едкого дыма, дебафающего зомби
    }
}
