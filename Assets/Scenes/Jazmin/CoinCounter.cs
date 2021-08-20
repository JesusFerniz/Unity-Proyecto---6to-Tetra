using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour
{
    [SerializeField] string lvlName;

<<<<<<< HEAD
    public float nuevo;
=======
    public bool isActive;
>>>>>>> iazz
    public int coins;
    public Text coinText;
    public Text newcoinText;
    public AudioClip clip;

    public void AddCoin()
    {
        int Savecoins = PlayerPrefs.GetInt("Coins_" + lvlName, 0);
<<<<<<< HEAD
        Savecoins++;
        PlayerPrefs.SetInt("Coins_" + lvlName, Savecoins);
        coins++;
=======
>>>>>>> iazz

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
        coinText.text = "Coins: " + coins;
    }

<<<<<<< HEAD
    public void multiplicador(float pordos)
    {
        nuevo = pordos * coins;
    }

    public void Power()
    {
        nuevo = coins;
=======
    public void Power()
    {
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
>>>>>>> iazz
    }

}

