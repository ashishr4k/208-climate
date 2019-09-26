using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public GameObject helpText;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision other){
      if(other.gameObject.tag == "Tree") {
          other.gameObject.GetComponent<Tree>().TakeDamage(damage);
      }
    }

    void OnMouseDown(){
        helpText.SetActive(false);
    }

    void OnMouseUp(){
        helpText.SetActive(true);
    }

}
