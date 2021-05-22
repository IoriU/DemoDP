using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpState : IState
{


    public IState DoState(PlayerController player)
    {
        PickUp(player.GetTarget());
        return player.wanderState;
    }

    private void PickUp(Transform coinTrans)
    {
        Coin coin = coinTrans.GetComponent<Coin>();
        coin.Picked();
    }
}
