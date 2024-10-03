using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public Rigidbody2D rbody;
    public float jumpForce = 5;
    public Logicmanager logicManager;
    bool birdIsDead = false;
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicManager.Gameover();
        birdIsDead = true;
    }
}
