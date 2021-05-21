using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpVida : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        VidaJugador health = FindObjectOfType<VidaJugador>();
        health.hpUP();
        Destroy(this.gameObject);

    }
}
