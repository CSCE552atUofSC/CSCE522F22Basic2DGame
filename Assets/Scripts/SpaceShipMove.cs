using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMove : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 moveVect = new Vector3(inputX, inputY, 0);
        moveVect *= (moveSpeed*Time.deltaTime);
        transform.Translate(moveVect);
    }
}






