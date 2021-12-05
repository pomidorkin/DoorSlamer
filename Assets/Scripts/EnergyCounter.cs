using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyCounter : MonoBehaviour
{
    private int maxEnergy = 100;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
        slider.minValue = 0;
        slider.maxValue = maxEnergy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddEnergy(int amount)
    {
        if ((slider.value + amount) < maxEnergy)
        {
            slider.value += amount;
        }
    }
}
