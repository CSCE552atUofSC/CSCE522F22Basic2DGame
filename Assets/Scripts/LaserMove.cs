using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMove : MonoBehaviour
{
    public float speed = 7.5f;
    public float timeDestroy = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Destroy(this.gameObject, timeDestroy);
        Physics2D.IgnoreLayerCollision(6, 6);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
            Destroy(this.gameObject);
    }
    /*
    private void OnCollisionExit2D(Collision2D collision)
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }*/
}






