using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimigosDamage : MonoBehaviour
{
    [SerializeField] public GameObject particlesPrefab = default;

    public float damageAmount = 1f;
    public AudioClip clip;

    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            VidaJugador player = other.GetComponent<VidaJugador>();
            if (player != null)
            {
                AudioSource.PlayClipAtPoint(clip, this.transform.position);
                anim.SetTrigger("Catch");
                GameObject particles = Instantiate(particlesPrefab, transform.position, transform.rotation);
                Destroy(particles, 1f);
                player.Damage(damageAmount);
            }
        }
    }

}
