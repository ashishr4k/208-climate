using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float healthDecreaseRate;
    int money;
    float CO2Level;
    float health;
    private float elapsedTime = 2f;
    private float TakeDamageInterval = 2f;
    public Text Money;
    public Slider healthbar;
    public Slider greenhousegasbar;
    // Start is called before the first frame update
    void Start()
    {
        money = 0;
        CO2Level = 0f;
        health = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        Money.text = "Cash: $" + money;
        healthbar.value = health;
        greenhousegasbar.value = CO2Level;

        healthDecreaseRate = greenhousegasbar.value;
        if(Time.time > elapsedTime){
            elapsedTime += TakeDamageInterval;
            health -= healthDecreaseRate;
        }
    }

    public void MoneyChange(string change, int value){
        if(change == "Increase"){
            money += value;
        }else{
            money -= value;
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
