using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    public int vidas = 3;

    public void hpUP()
    {
        if (vidas < 3)
        {
            vidas += 1;
           
        }

    }
}
