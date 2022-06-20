using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float damageAmount = 1f;
    public AudioClip clip;

    [SerializeField] public GameObject particlesPrefab = default;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VidaJugador player = other.GetComponent<VidaJugador>();
            if (player != null)
            {
                AudioSource.PlayClipAtPoint(clip, this.transform.position);
                GameObject particles = Instantiate(particlesPrefab, transform.position, transform.rotation);
                Destroy(particles, 1f);
                player.Damage(damageAmount);
            }
        }
    }



}
