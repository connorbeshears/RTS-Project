using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {
    public GameObject cursor;
    Vector3 mouseLoc;
	// Use this for initialization
	void Start () {
       mouseLoc = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
        mouseLoc = Input.mousePosition;
        cursor.transform.position = mouseLoc;
    }
}
