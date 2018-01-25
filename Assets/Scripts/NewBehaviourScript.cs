using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    GameObject friend;
    GameObject enemy;
    GreenMove enemyScript;
    public double damage;
    public double health = 100;
    //bool hasTarget;
    public float move;
    Vector3 enemyLocation;
    // Use this for initialization
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("GreenUnit");
        enemyScript = enemy.GetComponent<GreenMove>();
        //hasTarget = true;
        move = Random.Range(0.5f, 1.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (enemy != null)
        {

            GameObject marker = GameObject.FindGameObjectWithTag("marker");
            if (marker != null)
            {
                Vector3 markerLoc = marker.transform.position;
                transform.position = Vector3.MoveTowards(transform.position, markerLoc, move * Time.deltaTime);
            }

            else
            {
                enemyLocation = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z);
                if (Vector3.Distance(enemyLocation, transform.position) > 0.3f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, enemyLocation, move * Time.deltaTime);
                }
            }

            if (Vector3.Distance(enemyLocation, transform.position) < 1.0f && Vector3.Distance(enemyLocation, transform.position) > -1.0f)
            {
                enemyScript.health -= damage;
            }
        }

        if (health < 0)
        {
            Destroy(gameObject);
        }

        if (enemy == null)
        {
            enemy = GameObject.FindGameObjectWithTag("GreenUnit");
            enemyScript = enemy.GetComponent<GreenMove>();

        }
    }
}
