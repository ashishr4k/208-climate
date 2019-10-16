using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public int treeHealth;
    public int storage;
    private GameController gameController;
    public GameObject dustEffectPrefab;
    public GameObject treeFallingSoundEffectPrefab;
    public GameObject stump;
    //public AudioSource treeFallingSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        treeHealth = 30;
        //storage = 7;
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    public void TakeDamage(int damage)
    {

        if (treeHealth == damage)
        {
            //gameController.UpdateGasLevels("Increase", storage);
            gameController.MoneyChange("Increase", 10);
            gameController.GetComponent<GameController>().health -= 10;
            gameController.GetComponent<GameController>().CO2Level += 10;
            RenderSettings.fogDensity += 0.01f;
            //play animation
            //GetComponent<AudioSource>().Play(0);
            //treeFallingSoundEffect.Play();
            GameObject dustEffect = (GameObject)Instantiate(dustEffectPrefab, transform.position, transform.rotation);
            Instantiate(treeFallingSoundEffectPrefab, transform.position, transform.rotation);
            Instantiate(stump, transform.position, transform.rotation);
            Destroy(gameObject);

        }
        else
        {
            treeHealth -= damage;
            //GetComponent<AudioSource>().Play(0);
        }
    }
}
