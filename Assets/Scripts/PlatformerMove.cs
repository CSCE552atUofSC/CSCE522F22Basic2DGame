using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMove : MonoBehaviour
{
    public bool isFacingRight = true;
    Animator anim;
    SpriteRenderer sRender;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        sRender = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horiVal = Input.GetAxis("Horizontal");
        if(Mathf.Abs(horiVal) > 0.5f)
        {
            anim.ResetTrigger("StartIdle");
            anim.SetTrigger("StartWalk");

            if((horiVal > 0.5f && !isFacingRight) ||
                horiVal < 0.5f && isFacingRight)
            {
                sRender.flipX = !sRender.flipX;
                isFacingRight = !isFacingRight;
            }
        }
        else
        {
            anim.ResetTrigger("StartWalk");
            anim.SetTrigger("StartIdle");
        }
    }
}
