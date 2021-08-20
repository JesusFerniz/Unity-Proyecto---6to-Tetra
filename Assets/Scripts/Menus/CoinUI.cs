using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinUI : MonoBehaviour
{
    [SerializeField] string lvlName;
    [SerializeField] Text label;


    void Start()
    {
        int coins = PlayerPrefs.GetInt("Coins_" + lvlName, 0);

        label.text = "x" + coins;
    }


}
