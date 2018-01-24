using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSpawn : MonoBehaviour {
    public GameObject unit;
    // Use this for initialization
    void Start()
    {

    }

    public void taskOnClick()
    {
        Debug.Log("Ran Script");
        GameObject spawnPoint = GameObject.FindGameObjectWithTag("RedBuilding");
        Vector3 spawnPos = spawnPoint.transform.position;
        Instantiate(unit, spawnPos, Quaternion.identity);
    }
}
