using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    GameObject friend;
    GameObject enemy;
    GreenMove enemyScript;
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
            enemyLocation = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z);
            if (Vector3.Distance(enemyLocation, transform.position) > 0.3f)
            {
                transform.position = Vector3.MoveTowards(transform.position, enemyLocation, move * Time.deltaTime);
            }


            if (Vector3.Distance(enemyLocation, transform.position) < 0.7f)
            {
                enemyScript.health -= 2;
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
