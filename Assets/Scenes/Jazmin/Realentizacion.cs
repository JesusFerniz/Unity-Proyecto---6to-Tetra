using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Realentizacion : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerMovement lento = FindObjectOfType<PlayerMovement>();
            lento.Arena();
        }

        


    }



}
