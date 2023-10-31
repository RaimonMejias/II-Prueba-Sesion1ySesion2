using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedWPBehaviour : MonoBehaviour
{

    BedNotificator bedNotificator;

    public float offset = 1.0f;
    private bool toMove = false;
    private bool goToA = true;
    private Vector3 leftPosition;
    private Vector3 rightPosition;


    void Start() {
        bedNotificator = GameObject.FindWithTag("Player").GetComponent<BedNotificator>();
        leftPosition = transform.position - new Vector3(0, 0, offset);
        rightPosition = transform.position + new Vector3(0, 0, offset);
        bedNotificator.OnColissionWithPlayer += Move;
    }

    void Update() {
        if (toMove) {
            float distance = 2f * Time.deltaTime;
            Vector3 targetPosition = goToA? leftPosition : rightPosition;
            Vector3 movement = (targetPosition - transform.position).normalized;
            transform.Translate(movement * distance, Space.World);
            if (Vector3.Distance(transform.position, targetPosition) <= 0.1f) { goToA = !goToA; }                 
        }
    }

    private void Move() {
        toMove = true;
    }

}
