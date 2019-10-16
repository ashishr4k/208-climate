using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Tool : MonoBehaviour
{

    public int damage = 10;
    public float cutForce = 2f;
    private bool canCut = true;
    private bool cutting = false;
    public AudioSource choppingSoundEffect;

    void Update()
    {
        canCut = (GetComponent<Rigidbody>().velocity.magnitude < cutForce) ? false : true;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tree" && !cutting)
        {
            choppingSoundEffect.Play();
            other.gameObject.GetComponent<Tree>().TakeDamage(damage);
            cutting = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Tree")
        {
            cutting = false;
        }
    }
    void OnMouseDown()
    {
        //helpText.SetActive(false);
    }

    void OnMouseUp()
    {
        //helpText.SetActive(true);
    }

}
