using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

        if (health == 0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }

}