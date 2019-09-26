using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutDownTree : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tree"))
        {
            GetComponent<PlayerHealth>().health--;
            GetComponent<GreenHouseGasLevels>().CO2Level++;
        }
    }
}
