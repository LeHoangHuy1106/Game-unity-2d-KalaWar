using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandMovingHorizontal : MonoBehaviour
{
    float speed;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1, 10);
        rb = GetComponent<Rigidbody>();
       
       
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity= (Vector3.forward * speed);
    
    //    transform.Translate(Vector3.forward * speed *Time.deltaTime);
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if( collision.gameObject.tag=="Ground")
        {
            speed = -speed;
        }
        
    }

}
