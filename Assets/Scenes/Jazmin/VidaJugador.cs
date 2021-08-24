using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public AudioClip clip;

    public float vidasMax = 3f;
    public float currentHP;
    public GameObject canvasObject;

    public GameObject bola;

    public AudioClip clip2;

    public GameObject[] hearts;

    private bool Isinvensible;

    private void Start()
    {
        currentHP = vidasMax;
    }

    void Update()
    {
        if (currentHP < 1f)
        {
            hearts[0].SetActive(false);
        }
        if (currentHP < 2f)
        {
            hearts[1].SetActive(false);
        }
        if (currentHP < 3f)
        {
            hearts[2].SetActive(false);
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
        if (currentHP < 1f)
        {
            currentHP += 1f;
            hearts[0].SetActive(true);
        }
        if (currentHP < 2f && currentHP < 3f)
        {
            currentHP += 1f;
            hearts[1].SetActive(true);
        }
        else
        {
            currentHP += 1f;
            hearts[2].SetActive(true);
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
        bola.SetActive(true);
        yield return new WaitForSeconds(7f);
        bola.SetActive(false);
        Isinvensible = false;
        AudioSource.PlayClipAtPoint(clip, this.transform.position);
    }
}

