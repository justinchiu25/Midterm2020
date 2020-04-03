using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Spawner : MonoBehaviour
{
    public GameObject enemy;

    public GameObject powerUp;
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
        if (Timer <= 0) //Instantiate when timer is 0
        {
            rSpawn = Random.Range(0, 99);
            lSpawn = Random.Range(0, 99);
            if (rSpawn < 30)
            {
                Instantiate(enemy, spawn1.transform.position, Quaternion.identity); 
            }
            if (rSpawn >= 30 && rSpawn < 60)
            {
                Instantiate(enemy, spawn2.transform.position, Quaternion.identity); 
            }
            if (rSpawn >= 60 && rSpawn < 90)
            {
                Instantiate(enemy, spawn3.transform.position, Quaternion.identity); 
            }
            if (rSpawn >= 90 && rSpawn < 93)
            {
                Instantiate(powerUp, spawn1.transform.position, Quaternion.identity);
            }
            if (rSpawn >= 93 && rSpawn < 96)
            {
                Instantiate(powerUp, spawn2.transform.position, Quaternion.identity);
            }
            if (rSpawn >= 96)
            {
                Instantiate(powerUp, spawn3.transform.position, Quaternion.identity);
            }

            if (lSpawn < 30)
            {
                Instantiate(enemy, spawn1.transform.position, Quaternion.identity); 
            }
            if (lSpawn >= 30 && lSpawn < 60)
            {
                Instantiate(enemy, spawn2.transform.position, Quaternion.identity); 
            }
            if (lSpawn >= 60 && lSpawn < 90)
            {
                Instantiate(enemy, spawn3.transform.position, Quaternion.identity); 
            }    
            if (lSpawn >= 90 && lSpawn < 93)
            {
                Instantiate(powerUp, spawn1.transform.position, Quaternion.identity);
            }
            if (lSpawn >= 93 && lSpawn < 96)
            {
                Instantiate(powerUp, spawn2.transform.position, Quaternion.identity);
            }
            if (lSpawn >= 96)
            {
                Instantiate(powerUp, spawn3.transform.position, Quaternion.identity);
            }

            if (spawnTimer > 1) //Increases spawn timer
            {
                spawnTimer -= spawnInc;
            }

            Timer = spawnTimer;
        }


        


    }
}
