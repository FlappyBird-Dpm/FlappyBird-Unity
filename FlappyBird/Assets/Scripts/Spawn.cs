using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject tuberias;

    public float spawnTime = 2f;
    private float timer = 0f;

    public float height = 15f;
    // Start is called before the first frame update
    void Start()
    {
        Spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer<=spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            Spawner();
        }
        
    }

    void Spawner()
    {
        float randomHeight = Random.Range(-height, height);
        Instantiate(tuberias, new Vector3(transform.position.x, randomHeight, transform.position.z), transform.rotation);
    }
}
