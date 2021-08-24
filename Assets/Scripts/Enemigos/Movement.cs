using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 2;
    [SerializeField] float distanceTreshold = 0.25f;

    private WayPointPath path = default;
    private Transform[] waypoints;
    private int targetWaypoingIndex;
    private Transform target;

    //public Animator anim;
    private void Start()
    {
        //anim = GetComponent<Animator>();
    }

    public void SetPath(WayPointPath path)
    {
        this.path = path;

        waypoints = path.GetWayPoints();
        targetWaypoingIndex = 0;
        target = waypoints[targetWaypoingIndex];
        transform.position = waypoints[targetWaypoingIndex].position;
    }

    void Update()
    {
        if (target == null) return;

        //transform.LookAt(target.position);
        //Vector3 direction = waypoints[targetWaypoingIndex].position - transform.position;
        //direction = direction.normalized;
        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;

        transform.position += direction * Time.deltaTime * speed;

        float distance = Vector3.Distance(transform.position, target.position);

        if (distance < distanceTreshold)
        {
            targetWaypoingIndex++;
            if (targetWaypoingIndex < waypoints.Length)
            {
                target = waypoints[targetWaypoingIndex];
                //anim.SetBool("Walking", true);
            }
            else
            {
                target = null;
            }
        }
    }
}