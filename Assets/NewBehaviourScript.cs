using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    GameObject friend;
    GameObject enemy;
    public double health = 100;
    bool hasTarget;
    public float move = 0.4f;
    Vector3 enemyLocation;
    // Use this for initialization
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("GreenUnit");
        hasTarget = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (enemy != null)
        {
            enemyLocation = new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z);
            if (Vector3.Distance(enemyLocation, transform.position) > 0.5f)
            {
                transform.position = Vector3.MoveTowards(transform.position, enemyLocation, move * Time.deltaTime);
            }


            if (Vector3.Distance(enemyLocation, transform.position) < 0.7f)
            {
                health -= 2;
            }
        }

        if (health < 0)
        {
            Destroy(gameObject);
        }

        if (enemy == null)
        {
            enemy = GameObject.FindGameObjectWithTag("GreenUnit");
        }
    }
}
