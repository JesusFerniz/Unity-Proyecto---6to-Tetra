using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vidasMax = 3f;
    public float currentHP;
    public GameObject canvasObject;
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
            MakeActive();
        }
    }


    public void hpUP()
    {
        if (currentHP < 3f)
        {
            currentHP += 1f;          
        }

    }

    private void Dead()
    {
        Destroy(this.gameObject);

    }

    public void MakeActive()
    {
        canvasObject.SetActive(true);
    }
}
