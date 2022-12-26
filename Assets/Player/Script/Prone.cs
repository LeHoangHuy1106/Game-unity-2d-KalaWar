using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prone : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) && GetComponent<Jump>().isGround)
        {
                anim.SetBool("isProne", true);


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                anim.SetBool("isProneWalk", true);
                transform.Translate(Vector3.up * 2f * Time.deltaTime);
            }


            else if (Input.GetKey(KeyCode.RightArrow))
            {
                    anim.SetBool("isProneWalk", true);
                    transform.Translate(Vector3.forward * 2f * Time.deltaTime);
             
            }
            
            else if (!Input.GetKey(KeyCode.RightArrow) && !Input.GetKey(KeyCode.LeftArrow))
            {
                anim.SetBool("isProneWalk", false);
            }


        }
        else
        {
            anim.SetBool("isProne", false);

        }    
           
    }


}
