using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] string lvlName;

    public float nuevo;
    public int coins;
    public Text coinText;
    public Text newcoinText;

    public void AddCoin()
    {
        int Savecoins = PlayerPrefs.GetInt("Coins_" + lvlName, 0);
        Savecoins++;
        PlayerPrefs.SetInt("Coins_" + lvlName, Savecoins);
        coins++;

        coinText.text = "Coins: " + coins;
    }

    public void multiplicador(float pordos)
    {
        nuevo = pordos * coins;
    }

    public void Power()
    {
        nuevo = coins;
    }

}
