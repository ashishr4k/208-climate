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

    public void UpdateGasLevels(string change, int value){
        if(change == "Increase"){
            CO2Level += value;
        }else{
            CO2Level -= value;
        }
    }
}
