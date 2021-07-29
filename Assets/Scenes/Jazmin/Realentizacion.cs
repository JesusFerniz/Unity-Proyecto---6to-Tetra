using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Realentizacion : MonoBehaviour
{

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hola Lento");
            PlayerMovement lento = other.GetComponent<PlayerMovement>();
            if (lento != null)
            {
                lento.Velocidad();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Hola Lento");
            PlayerMovement lento = other.GetComponent<PlayerMovement>();
            if (lento != null)
            {
                lento.VelocidadNormal();
            }
        }
    }

}
