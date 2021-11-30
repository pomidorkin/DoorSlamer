using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBuilding : Building
{
    [SerializeField] GameObject weaponPrefab; // Лист вякого мусора, который будет скидываться на зомби

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
