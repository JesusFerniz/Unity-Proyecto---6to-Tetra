using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimigosDamage : MonoBehaviour
{
    public float damageAmount = 1f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            VidaJugador player = collision.gameObject.GetComponent<VidaJugador>();
            if (player != null)
            {
                player.Damage(damageAmount);
                Destroy(this.gameObject);
            }
        }

    }

}
