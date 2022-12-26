using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rb;
    public float jumpForce=400;
    public bool isGround;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isJump = Input.GetKey(KeyCode.Space);
        if (isGround)
        {
            if (isJump)
            {
                rb.AddForce(Vector3.up * jumpForce);
                isGround = false;
                anim.SetBool("isJump", true);
                if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
                {
                    //  transform.Translate(Vector3.forward * 200f * Time.deltaTime);
                    anim.SetBool("isJumpFar", true);
                }
                else
                {
                    anim.SetBool("isJumpFar", false);
                }

               
            }
            
        }
        else
        {
            anim.SetBool("isJump", false);
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("yellow") || collision.gameObject.CompareTag("blue") || collision.gameObject.CompareTag("DemonRock"))
        {
           
            isGround = true;

        }



    }
}
