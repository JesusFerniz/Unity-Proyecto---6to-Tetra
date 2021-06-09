using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOve : MonoBehaviour
{
    public float speed = 5.0f;
    private float rot = 0.0f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        rot -= Input.GetAxis("Horizontal") * speed;
        transform.eulerAngles = new Vector3(0.0f, rot, 0.0f);
    }
}
