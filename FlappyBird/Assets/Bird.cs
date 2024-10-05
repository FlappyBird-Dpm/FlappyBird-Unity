using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Animator movimiento;
    public Rigidbody2D rbody;
    public float jumpForce = 2;
    public Logicmanager logicManager;
    bool birdIsDead = false;
    public float rotationSpeed = 15f; // Velocidad de rotaci�n
    public float maxRotation = 45f;   // Rotaci�n m�xima permitida
    public float minRotation = -90f;  // Rotaci�n m�nima permitida

    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicmanager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !birdIsDead)
        {
            rbody.velocity = Vector2.up * jumpForce;
        }

        // Aplicar rotaci�n dependiendo de la velocidad vertical
        float rotationAngle = Mathf.Clamp(rbody.velocity.y * rotationSpeed, minRotation, maxRotation);
        transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManager.Gameover();
        birdIsDead = true;
    }
}
