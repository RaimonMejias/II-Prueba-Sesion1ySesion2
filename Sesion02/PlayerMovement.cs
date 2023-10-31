using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1.0f;
    public float mouseSensity = 5.0f;

    public float jumpForce = 2.0f;
    private Vector2 rotation = new Vector2();
    private Vector3 movement = new Vector3(); 
    private GameObject playerCamera;
    private Transform floorDetector;
    private Rigidbody parentBody;

    private bool grounded = false;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        playerCamera = transform.parent.transform.GetChild(0).gameObject;
        floorDetector = transform.parent.transform.GetChild(1).gameObject.transform;
        parentBody = transform.parent.gameObject.GetComponent<Rigidbody>();
    }

    void Update() {
        rotateCamera();
    }

    // Update is called once per frame
    void FixedUpdate() {
        if (floorDetector.position.y <= 0.6f) { grounded = true; }
        MovePlayer();
        jumpPlayer();
        Debug.DrawRay(playerCamera.transform.position, playerCamera.transform.forward * 2 , Color.red);
    }

    void MovePlayer() {
        movement = (
            transform.forward * Input.GetAxis("Vertical") + 
            transform.right * Input.GetAxis("Horizontal")
        );
        movement = movement * speed;
        parentBody.AddForce(movement, ForceMode.Force);
        parentBody.velocity = Vector3.zero;
        parentBody.angularVelocity = Vector3.zero;  // Parar al objeto cuando no se usan las flechas
        playerCamera.transform.position = transform.position + new Vector3(0, 0.5f, 0);  // Hacer que la posición de la camara no sea independiente del objeto   
    }

    void rotateCamera() {
        rotation.x += Input.GetAxisRaw("Mouse X") * mouseSensity * Time.deltaTime;
        rotation.y -= Input.GetAxisRaw("Mouse Y") * mouseSensity * Time.deltaTime;
        rotation.y = Mathf.Clamp(rotation.y, -90.0f, 90.0f); // Limitar la rotación horizontal a 90º maximo 
        transform.rotation = Quaternion.Euler(0, rotation.x, 0); // MODIFICACIÓN quitar el eje de rotación y para que no pueda caminar hacia arriba o abajo 
        playerCamera.transform.rotation = Quaternion.Euler(rotation.y, rotation.x, 0); // Rotar tanto camara como objeto
    }

    void jumpPlayer(){
        if (grounded && Input.GetAxis("Jump") > 0) {
            parentBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); 
            grounded = false; 
        }
    }

}
