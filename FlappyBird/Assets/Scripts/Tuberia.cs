using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberia : MonoBehaviour
{
    public float moveSpeed = 2f;

    public float destroydistance = -15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if (transform.position.x <= destroydistance)
        {
            Destroy(gameObject);
        }
    }
}
