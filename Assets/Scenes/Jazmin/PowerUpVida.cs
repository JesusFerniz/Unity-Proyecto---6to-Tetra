using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpVida : MonoBehaviour
{

    private void Update()
    {

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));

    }

    private void OnTriggerEnter(Collider other)
    {
        VidaJugador health = FindObjectOfType<VidaJugador>();
        health.hpUP();
        Destroy(this.gameObject);

    }
}
