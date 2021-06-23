using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invencible : MonoBehaviour
{
    public float damageAmount = 1f;
    bool isInvincible;

    void Start()
    {
        StartCoroutine(Coroutine());
    }

    public void Damage(int daño)
    {
        if (isInvincible)
        {

        }
        else
        {
            VidaJugador invencible = GetComponent<VidaJugador>();
            invencible.currentHP -= daño;
        }
    }


    private IEnumerator Coroutine()
    {
        isInvincible = true;
        yield return new WaitForSeconds(7f);
        isInvincible = false;

    }
}
