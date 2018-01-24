using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawn : MonoBehaviour {
    public GameObject Spawn;
	// Use this for initialization
	void Start () {
        InvokeRepeating("spawnUnit", 3.0f, 3.0f);
    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void spawnUnit()
    {
        Vector3 spawnPos = transform.position;
        Instantiate(Spawn, spawnPos, Quaternion.identity);
    }
}
