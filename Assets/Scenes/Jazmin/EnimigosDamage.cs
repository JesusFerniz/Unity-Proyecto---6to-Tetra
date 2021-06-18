using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimigosDamage : MonoBehaviour
{
    public float damageAmount = 1f;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VidaJugador player = other.GetComponent<VidaJugador>();
            if (player != null)
            {
                player.Damage(damageAmount);
            }
        }
    }

}
