using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;
    // GameObject _enemy;
    private float Timer;
    public float spawnTimer;
    public float spawnInc = 0.2f;

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    
    private int rSpawn;
    private int lSpawn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //Timer = spawnTimer;
    }

    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            rSpawn = Random.Range(0, 3);
            lSpawn = Random.Range(0, 3);
            if (rSpawn == 0)
            {
                Instantiate(enemy, spawn1.transform.position, Quaternion.identity); 
            }
            if (rSpawn == 1)
            {
                Instantiate(enemy, spawn2.transform.position, Quaternion.identity); 
            }
            if (rSpawn == 2)
            {
                Instantiate(enemy, spawn3.transform.position, Quaternion.identity); 
            }

            if (lSpawn == 0)
            {
                Instantiate(enemy, spawn1.transform.position, Quaternion.identity); 
            }
            if (lSpawn == 1)
            {
                Instantiate(enemy, spawn2.transform.position, Quaternion.identity); 
            }
            if (lSpawn == 2)
            {
                Instantiate(enemy, spawn3.transform.position, Quaternion.identity); 
            }

            if (spawnTimer > 1)
            {
                spawnTimer -= spawnInc;
            }

            Timer = spawnTimer;
        }


        


    }
}
