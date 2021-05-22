using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WanderState : IState
{
    public IState DoState(PlayerController player)
    {
        if (player.GetCoin() != null)
        {
            return player.chaseState;
        }
        if (player.GetTarget() == null)
        {
            player.RandomTarget();
        }
        if (player.GetDist() == 0)
        {
            player.RandomTarget();
        }
        player.MoveToTarget();
        return this;
    }
}
