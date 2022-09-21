using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public int randomSeed = 100;

    public float minSpawnTime = 0.1f;
    public float maxSpawnTime = 1.5f;

    public float minForce = 100.0f;
    public float maxForce = 200.0f;

    public float minTorque = 100.0f;
    public float maxTorque = 200.0f;

    public float topLocation;
    public float bottomLocation;
    
    public GameObject asteroid;
    float currSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(randomSeed);
        currSpawnTime = maxSpawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(currSpawnTime >= 0.0f)
        {
            currSpawnTime -= Time.deltaTime;
            return;
        }
        currSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        Vector3 location = Vector3.zero;
        //The GO is suppose to be on the right hand side of the screen
        location.x = transform.position.x;
        location.y = Random.Range(bottomLocation, topLocation);

        GameObject newAsteroid = Instantiate(asteroid, location, Quaternion.identity);

        float randForce = Random.Range(minForce, maxForce);
        newAsteroid.GetComponent<Rigidbody2D>().AddForce(Vector3.left*randForce);

        float randTorque = Random.Range(minTorque, maxTorque);
        newAsteroid.GetComponent<Rigidbody2D>().AddTorque(randTorque);
    }
}






