using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZombies : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
