using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpOnSpider : MonoBehaviour
{

    // MODIFICACION Se ha borrado todo lo anterior ya que no hacia falta
    public void OnCollisionEnter(Collision spiderCollision) {
        GameObject spider = spiderCollision.collider.gameObject;
        bool isSpider = spider.tag == "SpiderA" || spider.tag == "SpiderB" || spider.tag == "SpiderC"; // MODIFIACION para detectar cada tipo de araña
        if (isSpider && spider!= null) {
            bool isUp = transform.position.y > spider.transform.position.y; // MODIFICACION Ahora se comprueba de manera sencilla si el personaje esta por encima de la araña
            if (isUp) {
                ScoreController.scoreValue += 10;
                Destroy(spider);
            }

        }
    }

}
