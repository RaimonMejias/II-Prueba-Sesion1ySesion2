using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderABehaviour : MonoBehaviour
{

    public Transform pointA;
    public Transform pointB;

    public Transform bed1; // MODIFICACION
    public Transform bed2; // MODIFICACION

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

    // MODIFICACION DEL EJERCICIO 7 EN CLASE PARA EL EXAMEN 

    void OnPointerEnter() {
        Transform spiderB = GameObject.FindGameObjectWithTag("SpiderB").GetComponent<Transform>();
        spiderB.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        transform. position = bed1.position + new Vector3(0, 0.5f, 0);
        Transform spiderC = GameObject.FindGameObjectWithTag("SpiderC").GetComponent<Transform>();
        spiderC.position = bed2.position + new Vector3(0, 0.5f, 0);
    }

    void OnPointerExit() {}

    void OnPointerClick() {}

}
