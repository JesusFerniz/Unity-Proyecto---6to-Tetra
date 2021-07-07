using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invencible : MonoBehaviour
{
    bool isInvincible;

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    public void Damage(float da�o)
    {
        da�o = 0f;
        if (isInvincible)
        {
            VidaJugador invencible = GetComponent<VidaJugador>();
            invencible.currentHP = da�o ;
        }

    }


    private IEnumerator Coroutine()
    {
        isInvincible = true;
        yield return new WaitForSeconds(7f);
        isInvincible = false;

    }
}
