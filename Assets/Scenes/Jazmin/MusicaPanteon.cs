using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicaPanteon : MonoBehaviour
{
    public AudioClip clip;

    public void Start()
    {
        AudioSource.PlayClipAtPoint(clip, this.transform.position);
    }

}
