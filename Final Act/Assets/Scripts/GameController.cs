﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    float healthDecreaseRate;
    int money;
    public float CO2Level;
    public float health;
    private float elapsedTime = 2f;
    private float TakeDamageInterval = 2f;
    public Text Money;
    public Slider healthbar;
    public Slider greenhousegasbar;
    public GameObject HUD;

    void Start()
    {
        money = 0;
        CO2Level = 0f;
        health = 100f;
    }

    void Update()
    {
        Money.text = "Cash: $" + money;
        healthbar.value = health;
        greenhousegasbar.value = CO2Level;

        //healthDecreaseRate = greenhousegasbar.value;
        //if(Time.time > elapsedTime){
        //    elapsedTime += TakeDamageInterval;
        //    health -= healthDecreaseRate;
        //}

        if(OVRInput.GetDown(OVRInput.Button.One)){
            if(HUD.activeInHierarchy){
                HUD.SetActive(false);
            }else{
                HUD.SetActive(true);
            }
        }

        if (health <= 0)
        {
            SceneManager.LoadScene("Game Over");
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
            RenderSettings.fogDensity += 0.1f;

        }else{
            CO2Level -= value;
            RenderSettings.fogDensity -= 0.1f;
        }
    }
}
