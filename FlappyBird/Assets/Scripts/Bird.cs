using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    private Animator movimiento;
    public AudioSource FX;
    public AudioSource DeathFX;
    public Rigidbody2D rbody;
    public float jumpForce = 2;
    public Logicmanager logicManager;
    bool birdIsDead = false;
    public float rotationSpeed = 15f; // Velocidad de rotación
    public float maxRotation = 45f;   // Rotación máxima permitida
    public float minRotation = -90f;  // Rotación mínima permitida

    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicmanager>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !birdIsDead)
        {
            if (!FX.isPlaying)
            {
                FX.Play();
            }
            rbody.velocity = Vector2.up * jumpForce;
        }

        // Aplicar rotación dependiendo de la velocidad vertical
        float rotationAngle = Mathf.Clamp(rbody.velocity.y * rotationSpeed, minRotation, maxRotation);
        transform.rotation = Quaternion.Euler(0, 0, rotationAngle);
      
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!birdIsDead)
        {
            DeathFX.Play();
        }
        birdIsDead = true;
        logicManager.Gameover();
        
       
    }
}
