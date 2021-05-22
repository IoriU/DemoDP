using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounterSingleton : MonoBehaviour
{
    public static int counter;

    public static void Increment()
    {
        counter++;
    }
}
