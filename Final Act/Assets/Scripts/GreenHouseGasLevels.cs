using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenHouseGasLevels : MonoBehaviour
{
    public UnityEngine.UI.Slider GreenHouseGasSlider;
    public float CO2Level;

    public void FixedUpdate()
    {
        GreenHouseGasSlider.value = CO2Level;

        if (CO2Level > 100)
        {
            CO2Level = 100;
        }
    }
}