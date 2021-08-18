using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invencible : MonoBehaviour
{
    public float rotationSpeed;
    bool isInvincible;
    public AudioClip clip;

    private void Update()
    {

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));

    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!isInvincible)
            {
                AudioSource.PlayClipAtPoint(clip, this.transform.position);
                VidaJugador invencible = other.GetComponent<VidaJugador>();
                invencible.Invesibilidad();
            }
        }
    }

}
