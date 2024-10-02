using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject tuberia;

    public float spawnTime = 2f;
    public float timer = 0f;

    public float height = 2f;
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
        Instantiate(tuberia, new Vector3(transform.position.x, randomHeight, transform.position.z), transform.rotation);
    }
}
