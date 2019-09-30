using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public UnityEngine.UI.Slider healthSlider;
    public float health;

    public void FixedUpdate()
    {
        
        healthSlider.value = health;

        if (health > 100)
        {
            health = 100;
        }
    }
}