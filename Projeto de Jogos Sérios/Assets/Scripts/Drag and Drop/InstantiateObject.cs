/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObject : MonoBehaviour {


    public static bool queriesHitTriggers;

    public GameObject prefab;
    private GameObject instantiateObject;

    private void Update()
    { 
         if(Input.GetMouseButtonUp(0))
         {
            instantiateObject = Instantiate(prefab, new Vector3(0,0,0), Quaternion.identity) as GameObject;
            Debug.Log("It appears!");
         }

    }

}
*/