using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyZombies : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Player" || col.gameObject.tag == "Muro" || col.gameObject.tag == "Lapida")
        {
            StartCoroutine(Destruir());
        }
    }


    private IEnumerator Destruir()
    {
        yield return new WaitForSeconds(.5f);
        Destroy(this.gameObject);
    }
}
