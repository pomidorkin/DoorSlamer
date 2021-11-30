using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toilet : MonoBehaviour
{
    [SerializeField] GameObject toiletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        var saveManager = SaveManager.Instance;
        SaveManager.Instance.Load();
    }

    private void SpawnToilet(SaveManager saveManager)
    {
        // ���� ��� ������ �� ����� �������� ������, � ��������� ������, ������� ����� �������� ������
        // ����������� ����� ������ �����, ����� ������ ������
        Instantiate(toiletPrefab, this.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }

    private void Attack()
    {
        // ��������� ������ ������ ����, ����������� �����
    }
}
