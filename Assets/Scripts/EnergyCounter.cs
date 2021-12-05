using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyCounter : MonoBehaviour
{
    public int energy = 0;
    private int maxEnergy = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddEnergy(int amount)
    {
        if ((energy + amount) < maxEnergy)
        {
            energy += amount;
        }
    }
}
