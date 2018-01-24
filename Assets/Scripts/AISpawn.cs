using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawn : MonoBehaviour {
    public GameObject Spawn;
    public float chance = .1f;
    GameObject[] enemies;
    GameObject[] friends;
    int numEnemies = 0;
    float buff;
    float randNum;
	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        enemies = GameObject.FindGameObjectsWithTag("RedUnit");
        friends = GameObject.FindGameObjectsWithTag("GreenUnit");
        numEnemies = enemies.Length;

        chance = numEnemies / 1000f;

        randNum = Random.Range(0.0f, 1.0f);

        if(randNum < chance)
        {
            spawnUnit();
        }

        if(friends.Length < 1)
        {
            spawnUnit();
        }
    

	}

    void spawnUnit()
    {
        Vector3 spawnPos = transform.position;
        Instantiate(Spawn, spawnPos, Quaternion.identity);
    }
}
