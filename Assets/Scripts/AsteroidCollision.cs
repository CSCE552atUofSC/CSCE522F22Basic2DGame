using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidCollision : MonoBehaviour
{
    public string borderTag;
    public GameObject explode;
    GameObject sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        GameObject border = GameObject.FindGameObjectWithTag(borderTag);
        Collider2D thisCollider = GetComponent<Collider2D>();
        Collider2D[] borderColliders = border.GetComponents<Collider2D>();
        foreach (Collider2D c in borderColliders)
            Physics2D.IgnoreCollision(thisCollider, c);
        sceneManager = GameObject.FindGameObjectWithTag("Scene Manager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameObject newBoom = Instantiate(explode, transform.position, Quaternion.identity);
            Destroy(newBoom, 0.5f);
            Destroy(this.gameObject);
        }
        else if(collision.gameObject.tag == "Laser")
        {
            GameObject newBoom = Instantiate(explode, transform.position, Quaternion.identity);
            Destroy(newBoom, 0.5f);
            Destroy(collision.gameObject);//Destroys the laser
            sceneManager.SendMessage("AddPoints");
            Destroy(this.gameObject);
        }
    }
}
