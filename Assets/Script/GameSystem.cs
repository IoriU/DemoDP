using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSystem : MonoBehaviour
{
    public List<Coin> coinList;
    public CoinFactory coinFactory;
    public int counter;
    public UISystem uISystem;

    private void Start()
    {
        uISystem.UpdateText(counter, CoinCounterSingleton.counter);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void CreateCoin(string type)
    {
        GameObject coinObj = coinFactory.CreteCoin(type);
        Coin coin = coinObj.GetComponent<Coin>();
        coinList.Add(coin);
    }

    public Coin GetRandomCoin()
    {
        if (coinList.Count == 0)
        {
            return null;
        }
        return coinList[Random.Range(0, coinList.Count)];
    }

    
    public void Increment(Coin coin)
    {
        coinList.Remove(coin);
        counter++;
        CoinCounterSingleton.Increment();
        uISystem.UpdateText(counter, CoinCounterSingleton.counter);
    }




}
