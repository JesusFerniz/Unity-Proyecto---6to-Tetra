using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] string lvlName;

    public bool isActive;
    //public float nuevo;
    public int coins;
    public Text coinText;
    public AudioClip clip;

    public void AddCoin()
    {
        //int Savecoins = PlayerPrefs.GetInt("Coins_" + lvlName, 0);
        //Savecoins++;
        //PlayerPrefs.SetInt("Coins_" + lvlName, Savecoins);
        //coins++;

        //coinText.text = "Coins: " + coins;

        int Savecoins = PlayerPrefs.GetInt("Coins_" + lvlName, 0);

        if (isActive == true)
        {
            Savecoins += 2;
            coins += 2;
        }
        else
        {
            Savecoins++;
            coins++;
        }
        PlayerPrefs.SetInt("Coins_" + lvlName, Savecoins);
        coinText.text = "Coins: " + Savecoins;
    }

    public void Power()
    {
        //nuevo = coins;
        if (isActive)
            return;

        StartCoroutine(ActivarPoderDos());
    }

    private IEnumerator ActivarPoderDos()
    {
        isActive = true;
        yield return new WaitForSeconds(10f);
        isActive = false;
        AudioSource.PlayClipAtPoint(clip, this.transform.position);
    }

}
