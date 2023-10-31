using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderABehaviour : MonoBehaviour
{

    public Transform pointA;
    public Transform pointB;

    private bool goToA = false;

    // Update is called once per frame
    void Update()
    {
        float distance = 0.5f * Time.deltaTime;
        Vector3 targetPosition = goToA? pointA.position : pointB.position;
        Vector3 movement = (targetPosition - transform.position).normalized;
        transform.Translate(movement * distance, Space.World);
        transform.LookAt(pointB);
        if (transform.position == targetPosition) { goToA = !goToA; }
    }
}
