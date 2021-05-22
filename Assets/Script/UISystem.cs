using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISystem : MonoBehaviour
{
    public Text normalCounter;
    public Text singletonCounter;
    public GameSystem gameSystem;

    public void UpdateText(int normal, int singleton)
    {
        normalCounter.text = normal.ToString();
        singletonCounter.text = singleton.ToString();
    }

    public void OnGreenCoinButton()
    {
        gameSystem.CreateCoin("green");
    }

    public void OnBlueCoinButton()
    {
        gameSystem.CreateCoin("blue");
    }

}
