using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderCBehaviour : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0.5f) {
            GetComponent<Rigidbody>().AddForce(Vector3.up * 1, ForceMode.Impulse); 
        }
    }
}
