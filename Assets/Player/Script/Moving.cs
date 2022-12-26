using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    Rigidbody myBody;
    Animator anim;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positon = transform.localPosition;
        positon.x = 0f;
        transform.localPosition = positon;
        transform.Rotate(0f, Input.GetAxis("Vertical") * 0f, 0f);
        playerWalkingKeyBoard();
    }

    


    void playerWalkingKeyBoard()
    {
        float vel = Mathf.Abs(myBody.velocity.x);
        float h = Input.GetAxisRaw("Horizontal");
        if ( h>0)
        {
            Vector3 scale = transform.localScale;
            scale.z = 1;
            transform.localScale = scale;
            Vector3 movement = new Vector3(0f, 0f, h);
        //    movement.y = myBody.velocity.y * -30;
            // myBody.velocity = movement * speed * Time.deltaTime;
            transform.Translate(Vector3.forward * speed* 2f * Time.deltaTime);
            anim.SetBool("isWalk", true);
        }
        if (h < 0)
        {
            Vector3 scale = transform.localScale;
            scale.z = -1;
            transform.localScale = scale;
            Vector3 movement = new Vector3(0f, 0f, h);
            movement.y = myBody.velocity.y * -30;
            // myBody.velocity = movement * speed * Time.deltaTime;
            // myBody.AddForce(movement * speed * Time.deltaTime);
            transform.Translate(Vector3.back * speed * 2f * Time.deltaTime);
            anim.SetBool("isWalk", true);
        }
        if( h==0)
        {
            anim.SetBool("isWalk", false);
        }

    }
}
