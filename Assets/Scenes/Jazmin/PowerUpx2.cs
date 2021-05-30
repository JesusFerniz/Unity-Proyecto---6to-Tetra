using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpx2 : MonoBehaviour
{

    private void Start()
    {
        CoinCounter coin = FindObjectOfType<CoinCounter>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(ActivateCoins());
            Destroy(this.gameObject);
        }
    }


    IEnumerator ActivateCoins()
    {
        yield return new WaitForSeconds(7);
    }
}
