using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLaser : MonoBehaviour
{
    public GameObject laser;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (laser == null)
            return;
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject newLaser = 
                Instantiate(laser, transform.position, Quaternion.identity);
            Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(),
                                    newLaser.GetComponent<Collider2D>());

            //newLaser.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 2000.0f);
        }
    }
}
