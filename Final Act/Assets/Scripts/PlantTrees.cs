using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrees : MonoBehaviour
{
    [SerializeField]
    private GameObject treeTemplate;
	//[SerializeField]
	
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1)){
            Instantiate(treeTemplate, gameObject.transform.position + new Vector3(0,0,5), Quaternion.identity);
        };
    }
}
