using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairBehaviour : MonoBehaviour
{
    BedNotificator bedNotificator;
    public float jumpForce = 1.0f;
    private bool toJump = false;

    void Start()
    {
        bedNotificator = GameObject.FindWithTag("Player").GetComponent<BedNotificator>();
        bedNotificator.OnColissionWithPlayer += Jump;
    }

    // Update is called once per frame
    void Update()
    {
        if (toJump && transform.position.y <= 0.5f) {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);           
        }
    }

    void Jump() {
        toJump = true;
    }
}
