using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    private Building buildingSlot;
    [SerializeField] float moveSpeed = 3f;
    [SerializeField] int health = 100;
    [SerializeField] int damage = 15;
    private bool isAttacking = false;
    [SerializeField] float attackSpeed = 2.0f;
    private float attackCounter = 0;

    private void Start()
    {
        buildingSlot = FindObjectOfType<Building>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * (moveSpeed * Time.deltaTime));
        transform.rotation = Quaternion.Euler(0, 0, 0);
        /* if (isAttacking)
         {
             Attack();
         }*/



        attackCounter += Time.deltaTime;
        if (attackCounter >= attackSpeed)
        {
            attackCounter = 0;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            Debug.Log("Collision with the door");
            if (collision.gameObject.GetComponent<Door>())
            {
                health -= collision.gameObject.GetComponent<Door>().GetDoorDamage();
                Debug.Log("My health: " + health);
                if(health <= 0)
                {
                    DestroySelf();
                }
            }
        }
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }

    public void Attack()
    {
        moveSpeed = 0f;
        this.isAttacking = true;
        Debug.Log("Attacking...");
        InvokeRepeating("DealDamage", 0f, attackSpeed);
    }

    private void DealDamage()
    {
        buildingSlot.DecreaseHealth(damage);
    }
}
