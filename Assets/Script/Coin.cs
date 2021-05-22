using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameSystem gameSystem;

    private void Start()
    {
        GameObject gameSystemObj = GameObject.Find("GameSystem");
        gameSystem = gameSystemObj.GetComponent<GameSystem>();
    }
    public void Picked() 
    {
        gameSystem.Increment(this);
        Destroy(this.gameObject);
    }
}
