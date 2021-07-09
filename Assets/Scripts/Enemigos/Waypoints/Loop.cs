using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loop : MonoBehaviour
{
    [SerializeField] float speed = 2;
    [SerializeField] float distanceTreshold = 0.25f;

    private WayPointPath path = default;
    private Transform[] waypoints;
    private int targetWaypoingIndex;
    private Transform target;

    public void SetPath(WayPointPath path)
    {
        this.path = path;

        waypoints = path.GetWayPoints();
        targetWaypoingIndex = 0;
        target = waypoints[targetWaypoingIndex];
        transform.position = waypoints[targetWaypoingIndex].position;
    }

    private void Update()
    {
        //If there is not a target, do nothing
        if (target == null) return;

        //Rotation - Look at the target (next point in the waypoints)
        transform.LookAt(target.position);

        //Calculate direction of the next target
        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;

        //The movement
        transform.position += direction * Time.deltaTime * speed;

        //Check if we are in the next point
        float distance = Vector3.Distance(transform.position, target.position);
        if (distance < distanceTreshold)
        {   //Update the next point
            targetWaypoingIndex++;
            if (targetWaypoingIndex < waypoints.Length)
                target = waypoints[targetWaypoingIndex];
            else
                target = null;
        }
    }

}