using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float change;
    public float maxY;
    public float minY;
    public int Health;
    private Vector2 targetPos;
    public TMP_Text healthText;
    
    // Start is called before the first frame update
    void Start()
    {
        Health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxY)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y + change);
        } 
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minY) 
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - change);
        }

        if (Health == 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }

        healthText.text = "Health: " + Health;
    }
}
