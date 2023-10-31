using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bed : MonoBehaviour
{

/*
    ESTO ES LO QUE HABIA ORIGINALMENTE 
    
    public delegate void Message();
    public event Message OnColissionWithPlayer = delegate { };
    
    public void OnCollisionEnter(Collision objectCollision) {
        if (objectCollision.collider.gameObject.tag == "Player") {
            OnColissionWithPlayer();
        }
    }
*/

    public delegate void Message();
    public event Message OnColissionWithPlayer = delegate { };
    
    public void OnCollisionEnter(Collision objectCollision) {
        if (objectCollision.collider.gameObject.tag == "Player") {
            OnColissionWithPlayer();
        }
    }
}
