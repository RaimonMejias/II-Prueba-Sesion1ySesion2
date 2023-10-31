using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderBBehavour : MonoBehaviour
{

    public Vector3 pointA;
    public Vector3 pointB;
    private bool goToA = false;
    // Start is called before the first frame update
    void Start()
    {
        pointA = new Vector3(RandomNumber(-2.0f, 6.0f), transform.position.y, RandomNumber(2.0f, 4.0f));   
        pointB = new Vector3(RandomNumber(-2.0f, 6.0f), transform.position.y, RandomNumber(2.0f, 4.0f));  
    }

    // Update is called once per frame
    void Update()
    {
        float distance = 2f * Time.deltaTime;
        Vector3 targetPosition = goToA? pointA : pointB;
        Vector3 movement = (targetPosition - transform.position).normalized;
        transform.Translate(movement * distance, Space.World);
        transform.LookAt(pointB);
        if (transform.position == targetPosition) { goToA = !goToA; }        
    }

    float RandomNumber(float min, float max) { 
        return UnityEngine.Random.Range(min, max);
    }
}
