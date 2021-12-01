using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    [SerializeField] float moveSpeed = 3f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * (moveSpeed * Time.deltaTime));
        transform.rotation = Quaternion.Euler(0, 0, 0);
        /*transform.position = Vector3.MoveTowards(transform.position, new Vector3(-10, 0,0), moveSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0, 0, 0);*/
    }

    void OnCollisionEnter(Collision collision)
    {
            Debug.Log("Collision with the door");
    }
}
