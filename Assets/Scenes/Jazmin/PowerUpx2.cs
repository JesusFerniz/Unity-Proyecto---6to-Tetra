using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpx2 : MonoBehaviour
{
    bool OnEnable;

    void Start()
    {
        StartCoroutine(ActivateCoins());
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (OnEnable)
            {
                StartCoroutine(ActivateCoins());
            }             
        }
    }


    IEnumerator ActivateCoins()
    {
        OnEnable = true;
        yield return new WaitForSeconds(7f);
        OnEnable = false;
    }
}
