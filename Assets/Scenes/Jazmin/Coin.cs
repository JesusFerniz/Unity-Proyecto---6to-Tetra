using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed;
    public AudioClip clip;

    private void Update()
    {

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));

    }

    private void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(clip, this.transform.position);
        Destroy(this.gameObject);
        CoinCounter coincounter = FindObjectOfType<CoinCounter>();
        coincounter.AddCoin();

    }
}
