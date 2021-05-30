using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    int coins;
    public Text coinText;
    public Text newcoinText;

    public void AddCoin()
    {
        coins++;

        coinText.text = "Coins: " + coins;
    }

}
