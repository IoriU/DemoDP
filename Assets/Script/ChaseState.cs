using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseState : IState
{
    public IState DoState(PlayerController player)
    {
        
        if (player.GetTarget().GetComponent<Coin>() == null)
        {
            if (player.GetCoin() == null)
            {
                return player.wanderState;
            }
        }
        if (player.GetDist() < 0.5f)
        {
            return player.pickUpState;
        }
        player.MoveToTarget();
        return this;
    }
}
