using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vidasMax = 3;
    public float currentHP;


    public void Damage(float amount)
    {
        vidasMax -= amount;
        if(currentHP <= 0f)
        {
            Dead();
        }
    }


    public void hpUP()
    {
        if (vidasMax < 3)
        {
            vidasMax += 1;          
        }

    }

    private void Dead()
    {
        Destroy(this.gameObject);
    }
}
