using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vidasMax = 3f;
    public float currentHP;
    public GameObject canvasObject;
    public GameObject[] hearts;
    private void Start()
    {
        currentHP = vidasMax;

    }
    void Update()
    {
        if (currentHP < 1)
        {
            Destroy(hearts[0].gameObject);
        }
        if (currentHP < 2)
        {
            Destroy(hearts[1].gameObject);
        }
        if (currentHP < 3)
        {
            Destroy(hearts[2].gameObject);
        }
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
        if (vidasMax < 3f)
        {
            vidasMax += 1f;          
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
