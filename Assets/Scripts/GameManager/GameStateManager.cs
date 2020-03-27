using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameState currentState;
    
    private int Health;


    public int _health
    {
        get { return Health; }
        set { Health = value; }
    }

    void Start()
    {
        ChangeState(new StatePlaying(this)); // Set initial state.
       // Health = gameObject.GetComponent<PlayerController>().Health;
    }

    void Update()
    {
        currentState.Run();
    }

    // Change state.
    public void ChangeState(GameState newState)
    {
        if (currentState != null) currentState.Leave();
        currentState = newState;
        currentState.Enter();
    }
    
}
