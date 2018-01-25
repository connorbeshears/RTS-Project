using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {
    public GameObject cursor;
    public GameObject Heading;
    Vector3 mouseLoc;
	// Use this for initialization
	void Start () {
       mouseLoc = Input.mousePosition;
	}
	
	// Update is called once per frame
	void Update () {
        mouseLoc = Input.mousePosition / 100;
        cursor.transform.position = mouseLoc;

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Instantiate(Heading, mouseLoc, Quaternion.identity);
        }
    }
}
