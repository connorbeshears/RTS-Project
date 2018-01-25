using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadingScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject find = GameObject.FindGameObjectWithTag("marker");
        if(find != gameObject)
        {
            Destroy(find);
        }
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
