using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatePlaying : GameState
{
    
    public StatePlaying(GameStateManager theManager) :
        base(theManager) // Derived class constructor calls base class constructor.
    {

    }

    public override void Run() // Overriden from base class.
    {

        /*  if (GameStateManager.Health < 0)
           {
               manager.ChangeState(new StateEnding(manager)); // Change to waiting state.
           }
   
       }*/
    }

}

