using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopWayPoint : MonoBehaviour
{

    public Transform[] GetWaypoints()
    {
        Transform[] waypoints = new Transform[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            waypoints[i] = transform.GetChild(i);
        }

        return waypoints;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;

        for (int i = 0; i < transform.childCount; i++)
        {
            Gizmos.DrawSphere(transform.GetChild(i).position, 0.25f);

            if (i < transform.childCount - 1)
                Gizmos.DrawLine(transform.GetChild(i).position,
                    transform.GetChild(i + 1).position);
        }
    }
}