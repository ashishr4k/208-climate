using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour
{
    float healthDecreaseRate;
    int money;
    [SerializeField]
    private GreenHouseGasLevels ggController;
    [SerializeField]
    private PlayerHealth playerHealth;
    private float elapsedTime = 2f;
    private float TakeDamageInterval = 2f;

    public Text Money;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Money.text = "Cash: $" + money;
        healthDecreaseRate = ggController.GreenHouseGasSlider.value;
        if(Time.time > elapsedTime){
            elapsedTime += TakeDamageInterval;
            //Debug.Log("Player Health Decreased by: " + healthDecreaseRate);
            playerHealth.health -= healthDecreaseRate;
        }
    }

    public void MoneyChange(string change, int value){
        if(change == "Increase"){
            money += value;
            //animation
        }else{
            money -= value;
            //animation

        }
    }
}
