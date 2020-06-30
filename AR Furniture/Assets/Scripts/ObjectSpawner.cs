using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject Chair;
    public GameObject Table;

    private PlacementIndicator placementIndicator;


    void Start()
    {
        placementIndicator = FindObjectOfType<PlacementIndicator>();

    }


    public void SpawnChair() {

        GameObject obj = Instantiate(Chair,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }
   
   
    public void SpawnTable() {

        GameObject obj = Instantiate(Table,
                placementIndicator.transform.position, placementIndicator.transform.rotation);

    }    
    
   
}
