using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrees : MonoBehaviour
{
    [SerializeField]
    private GameObject treeTemplate;
    private bool ready;
    private GameController gc;
    public GameObject treeGrowSoundEffectPrefab;


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
            Instantiate(treeGrowSoundEffectPrefab, transform.position, transform.rotation);
            Instantiate(treeTemplate, gameObject.transform.position, Quaternion.identity);
            GameObject.Find("GameController").GetComponent<GameController>().health += 10;
            GameObject.Find("GameController").GetComponent<GameController>().CO2Level -= 10;
            //gc.UpdateGasLevels("Decrease", 7);
            
            RenderSettings.fogDensity -= 0.01f;
            //Debug.Log("Plant");
            Destroy(this.gameObject);
        }
    }
}
