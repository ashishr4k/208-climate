using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantTrees : MonoBehaviour
{
    [SerializeField]
    private GameObject treeTemplate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1)){
            //use raycast to detect floor height and instantiate tree object
        };
    }
}
