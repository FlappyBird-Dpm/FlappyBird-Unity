using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector : MonoBehaviour
{ 
    public Logicmanager logicManager;
    void Start()
    {
        logicManager = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicmanager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bird")
        {
            logicManager.AddScrore();
        }
    }
}
