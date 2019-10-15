using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrees : MonoBehaviour
{
    [SerializeField]
    private GameObject treeTemplate;
    private bool ready;
    private GameController gc;
    // Start is called before the first frame update
    void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<OVRGrabbable>().isGrabbed)
        {
            ready = true;
        }
        /*
        if(Input.GetMouseButtonDown(1)){
            Instantiate(treeTemplate, gameObject.transform.position + new Vector3(0,0,5), Quaternion.identity);
        };
        */
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Ground" && ready && !GetComponent<OVRGrabbable>().isGrabbed)
        {
            GameObject newtree = Instantiate(treeTemplate, gameObject.transform.position, Quaternion.identity);
            newtree.GetComponent<Animator>().SetTrigger("Grow");
            gc.UpdateGasLevels("Decrease", 7);
            Destroy(this.gameObject);
        }
    }
}
