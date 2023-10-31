using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedNotificator : MonoBehaviour {
    public delegate void Message();
    public event Message OnColissionWithPlayer = delegate { };

    public void OnCollisionEnter(Collision objectCollision) {
        if (objectCollision.collider.gameObject.tag == "BedWithPerson") {
            OnColissionWithPlayer();
        }
    }

}
