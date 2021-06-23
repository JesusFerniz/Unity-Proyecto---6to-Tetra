using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZombies : MonoBehaviour
{
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
