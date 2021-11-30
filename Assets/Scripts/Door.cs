using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject doorPrefab;
    public Animator animator;

    void Start()
    {
        var saveManager = SaveManager.Instance;
        SaveManager.Instance.Load();
        SpawnDoor();
    }

    private void SpawnDoor()
    {
        GameObject doorToCreate = Instantiate(doorPrefab, this.transform.position, Quaternion.identity);
        doorToCreate.transform.parent = gameObject.transform;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OpenDoor();
        }
    }

    public void OpenDoor()
    {
        animator.Play("DoorOpeningAnimation");
    }
}
