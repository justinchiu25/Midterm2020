using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState
{
    protected GameStateManager manager; // The manager that contains the state machine.

    public abstract void Run(); // This is abstract so it MUST be implemented in derived classes.
    public virtual void Enter() { } // Virtual so can be overriden in derived classes.
    public virtual void Leave() { }

    public GameState(GameStateManager theManager) // Constructor that takes an argument.
    {
        manager = theManager;
    }
}
