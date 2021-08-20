using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpx2 : MonoBehaviour
{
    public float rotationSpeed;
    bool OnEnable;
    public AudioClip clip;


    private void Update()
    {

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, rotationSpeed * Time.deltaTime, 0f));

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!OnEnable)
            {
<<<<<<< HEAD
                StartCoroutine(ActivateCoins());

                CoinCounter coin = GetComponent<CoinCounter>();
                coin.Power();
            }             
        }
    }

    IEnumerator ActivateCoins()
    {
        OnEnable = true;
        yield return new WaitForSeconds(7f);
        OnEnable = false;
    }
=======
                AudioSource.PlayClipAtPoint(clip, this.transform.position);
                CoinCounter coin = FindObjectOfType<CoinCounter>();
                coin.Power();
            }
        }
    }

>>>>>>> iazz
}
