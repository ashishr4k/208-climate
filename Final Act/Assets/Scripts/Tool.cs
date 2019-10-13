using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Tool : MonoBehaviour
{
    //public GameObject helpText;
    public int damage = 10;
    public float cutForce = 2f;
    private bool canCut = true;
    private bool cutting = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        canCut = (GetComponent<Rigidbody>().velocity.magnitude < cutForce) ? false : true;
    }

    void OnTriggerEnter(Collider other){
      if(other.gameObject.tag == "Tree" && !cutting) {
          other.gameObject.GetComponent<Tree>().TakeDamage(damage);
          cutting = true;
      }
    }

    void OnTriggerExit(Collider other){
        if(other.gameObject.tag == "Tree") {
            cutting = false;
        }
    }
    void OnMouseDown(){
        //helpText.SetActive(false);
    }

    void OnMouseUp(){
        //helpText.SetActive(true);
    }

}
