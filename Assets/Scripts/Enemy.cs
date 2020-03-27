using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Enemy : MonoBehaviour
{
    public float speed;
    public static int score;
    public GameObject player;
    //private GameObject _enemy;
    public float xPos;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //_enemy = gameObject.GetComponent<Spawner>()._enemy;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        if (gameObject.transform.position.x < xPos)    
        {
            Destroy(GameObject.Find("Enemy(Clone)"));
            score++;
        }
        
        //scoreText.text = "Score: " + score;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.CompareTag("Player"))
       {
           other.GetComponent<PlayerController>().Health--;
           Debug.Log("Destroyed");
           Debug.Log( other.GetComponent<PlayerController>().Health);
       }
    }
}
