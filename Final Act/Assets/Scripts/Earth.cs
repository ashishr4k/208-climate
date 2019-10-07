using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earth : MonoBehaviour
{
    //public Animator earthAnimator;
    GameObject player;
    float health;
    public Texture earthTexture1;
    public Texture earthTexture2;
    public Texture earthTexture3;
    public Texture earthTexture4;
    public Texture earthTexture5;
    public Texture earthTexture6;
    Renderer earth;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Start()
    {
        earth = GetComponent<Renderer>();
    }
    public void Update()
    {
        health = player.GetComponent<PlayerHealth>().health;
        
        if (health > 0 && health < 16)
        {
            
            earth.material.SetTexture("_MainTex", earthTexture1);
        }
        
        if (health > 16 && health < 32)
        {
            earth.material.SetTexture("_MainTex", earthTexture2);
        }
        if (health > 32 && health < 48)
        {
            earth.material.SetTexture("_MainTex", earthTexture3);
        }
        if (health > 48 && health < 64)
        {
            earth.material.SetTexture("_MainTex", earthTexture4);
        }
        if (health > 64 && health < 80)
        {
            earth.material.SetTexture("_MainTex", earthTexture5);
        }
        if (health > 80 && health < 100)
        {
            earth.material.SetTexture("_MainTex", earthTexture6);
        }
        
    }

}
