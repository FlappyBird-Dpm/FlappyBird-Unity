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
    public float rotationSpeed = 15;
    // Start is called before the first frame update
    void Start()
    {

        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicmanager>();
    }

    // Update is called once per frame
    void Update()
    {   

        if(Input.GetKeyDown(KeyCode.Space) && !birdIsDead)
        {
            rbody.velocity = Vector2.up * jumpForce;

        }
        transform.rotation = Quaternion.Euler(0,0,rbody.velocity.y*rotationSpeed*Time.deltaTime*100);
        
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManager.Gameover();
        birdIsDead = true;
    }
}
