using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockLvl : MonoBehaviour
{
    [SerializeField] string lvlName;
    [SerializeField] GameObject candado;
    [SerializeField] GameObject costo;
    [SerializeField] Button boton;
    [SerializeField] int coinsToUnlock;

    void Start()
    {
        int coins = PlayerPrefs.GetInt("Coins_" + lvlName, 0);

        if(coins >= coinsToUnlock)
        {
            Unlock();
        }
        else
        {
            Lock();
        }
    }


    [ContextMenu("Unlock")]
    private void Unlock()
    {
        candado.SetActive(false);
        costo.SetActive(false);

        boton.interactable = true;


    }

    [ContextMenu("Lock")]
    private void Lock()
    {
        candado.SetActive(true);
        costo.SetActive(true);

        boton.interactable = false;
    }
}
