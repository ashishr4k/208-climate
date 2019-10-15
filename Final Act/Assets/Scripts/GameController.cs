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
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        money = 0;
        CO2Level = 0f;
        health = 100f;
        Money.text = "Cash: $0";
    }

    // Update is called once per frame
    void Update()
    {
        //healthbar.value = health;
        //greenhousegasbar.value = CO2Level;
        healthDecreaseRate = greenhousegasbar.value/10;
        if(Time.time > elapsedTime){
            elapsedTime += TakeDamageInterval;
            healthbar.value -= healthDecreaseRate;
        }

        if(OVRInput.GetDown(OVRInput.Button.One)){
            if(test.activeInHierarchy){
                test.SetActive(false);
            }else{
                test.SetActive(true);
            }
        }
    }

    public void MoneyChange(string change, int value){
        if(change == "Increase"){
            Money.text = "Cash: $" + (money + value);
        }else{
            Money.text = "Cash: $" + (money - value);
        }
    }
    public void UpdateGasLevels(string change, int value){
        if(change == "Increase"){
            greenhousegasbar.value += value;
            RenderSettings.fogDensity += 0.1f;
        }else{
            greenhousegasbar.value -= value;
            RenderSettings.fogDensity -= 0.1f;
        }
    }
}
