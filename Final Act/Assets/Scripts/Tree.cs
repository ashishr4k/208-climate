using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public int health;
    public int storage;
    private GameController gameController;
    public GameObject dustEffectPrefab;
    public AudioClip growingClip;
    public AudioClip fallingClip;
    public AudioClip cuttingClip;

    // Start is called before the first frame update
    void Start()
    {
        health  = 30;
        storage = 7;
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    public void TakeDamage(int damage){

        if(health == damage ){
            gameController.UpdateGasLevels("Increase", storage);
            gameController.MoneyChange("Increase", 10);
            //play animation
            GetComponent<AudioSource>().Play(0);
            GameObject dustEffect = (GameObject)Instantiate(dustEffectPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }else{
            health -= damage;
            GetComponent<AudioSource>().Play(0);
        }
    }
}
