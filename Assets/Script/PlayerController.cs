using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public Transform[] movePoint;
    private int randomPoint;
    public Transform target;
    public float speed;
    public float dist;
    public IState state;
    public GameSystem gameSystem;

    public WanderState wanderState = new WanderState();
    public ChaseState chaseState = new ChaseState();
    public PickUpState pickUpState = new PickUpState();
    public string msg;
    void Start()
    {
        state = wanderState;
    }


    void Update()
    {
        state = state.DoState(this);
        if (state == wanderState)
        {
            msg = "wander";
        } else if (state == chaseState)
        {
            msg = "chase";
        } else if (state == pickUpState)
        {
            msg = "pick";
        }
    }

    public Coin GetCoin()
    {
        Coin coin = gameSystem.GetRandomCoin();
        if (coin == null)
        {
            return null;
        }
        target = coin.transform;
        CheckDist();
        return coin;

    }
    public void RandomTarget()
    {
        randomPoint = Random.Range(0, movePoint.Length);
        target = movePoint[randomPoint];
    }

    public void MoveToTarget()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed);
        CheckDist();
    }

    public void CheckDist()
    {
        dist = Vector2.Distance(transform.position, target.position);
    }

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    public float GetDist()
    {
        return dist;
    }

    public Transform GetTarget()
    {
        return target;
    }

}
