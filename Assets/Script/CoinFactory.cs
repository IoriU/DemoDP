using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFactory : MonoBehaviour
{
    public GameObject greenCoin;
    public GameObject blueCoin;

    public GameObject CreteCoin(string type)
    {
        if (type.Equals("blue"))
        {
            return Instantiate(blueCoin, new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f)), Quaternion.identity);
        }
        else if (type.Equals("green"))
        {
            return Instantiate(greenCoin, new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f)), Quaternion.identity);
        }
        return null;
    }
}
