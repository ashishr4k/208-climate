using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    int health;
    int storage;
    [SerializeField]
    private GreenHouseGasLevels ggController;
    [SerializeField]
    private GameController gameController;
    // Start is called before the first frame update
    void Start()
    {
        health  = 30;
        storage = 1;
    }

    public void TakeDamage(int damage){

        if(health == damage ){
            Debug.Log("Tree cut");
            ggController.UpdateGasLevels("Increase", storage);
            gameController.MoneyChange("Increase", 10);
            //play animation
            Destroy(gameObject);
        }else{
            health -= damage;
        }
    }
}
