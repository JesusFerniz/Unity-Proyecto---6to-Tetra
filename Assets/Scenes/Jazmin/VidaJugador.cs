using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public float vidasMax = 3f;
    public float currentHP;
<<<<<<< HEAD
    public GameObject canvasObject;
    public AudioClip clip;

    public GameObject[] hearts;

    private bool Isinvensible;

=======
    public GameObject LoseCanvas;
    public GameObject[] hearts;

>>>>>>> JFerniz11
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
        LoseCanvas.SetActive(true);
    }

    private IEnumerator ActivarInvesibilidad()
    {
        Isinvensible = true;
        yield return new WaitForSeconds(7f);
        Isinvensible = false;
        AudioSource.PlayClipAtPoint(clip, this.transform.position);
    }
}

