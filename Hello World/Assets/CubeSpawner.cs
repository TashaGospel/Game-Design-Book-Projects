using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour {
    public GameObject cubePrefabVar;

	// Use this for initialization
	void Start () {
        //Instantiate(cubePrefabVar);
        double a = 0.5;
        print(a);
        
	}
	
	// Update is called once per frame
	void Update () {
        Instantiate(cubePrefabVar);
		
	}
}
