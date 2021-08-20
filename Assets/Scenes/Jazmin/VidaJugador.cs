﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public AudioClip clip;

    public float vidasMax = 3f;
    public float currentHP;
    public GameObject canvasObject;
    public AudioClip clip2;

    public GameObject[] hearts;

    private bool Isinvensible;

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
        if (Isinvensible)
            return;
        AudioSource.PlayClipAtPoint(clip2, this.transform.position);
        currentHP -= amount;
        if (currentHP <= 0f)
        {
            Dead();
            MakeActive();
        }
    }

    public void Invesibilidad()
    {
        if (Isinvensible)
            return;
        StartCoroutine(ActivarInvesibilidad());
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

    private IEnumerator ActivarInvesibilidad()
    {
        Isinvensible = true;
        yield return new WaitForSeconds(7f);
        Isinvensible = false;
        AudioSource.PlayClipAtPoint(clip, this.transform.position);
    }
}

