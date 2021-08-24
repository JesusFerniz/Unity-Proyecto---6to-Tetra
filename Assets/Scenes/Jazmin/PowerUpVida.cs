using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpVida : MonoBehaviour
{
    public float rotationSpeed;
    public AudioClip clip;



    private void Update()
    {

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AudioSource.PlayClipAtPoint(clip, this.transform.position);
            VidaJugador health = FindObjectOfType<VidaJugador>();
            health.hpUP();
            Destroy(this.gameObject);
        }

    }
}
