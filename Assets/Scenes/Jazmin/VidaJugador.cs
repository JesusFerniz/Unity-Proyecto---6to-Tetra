using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vidasMax = 3f;
    public float currentHP;

    private void Start()
    {
        currentHP = vidasMax;

    }

    public void Damage(float amount)
    {
        currentHP -= amount;
        if(currentHP <= 0f)
        {
            Dead();
        }
    }


    public void hpUP()
    {
        if (vidasMax < 3f)
        {
            vidasMax += 1f;          
        }

    }

    private void Dead()
    {
        Destroy(this.gameObject);
    }
}
