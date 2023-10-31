using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpOnSpider : MonoBehaviour
{
    private Transform floorDetector;

    public void Start() {
        floorDetector = transform.parent.transform.GetChild(1).gameObject.transform;
    }

    public void OnCollisionEnter(Collision spiderCollision) {
        GameObject spider = spiderCollision.collider.gameObject;
        Debug.Log(spider);
        if (spider.tag == "Spider") {
            ScoreController.scoreValue += 10;
            Destroy(spider);
        }
    }

}
