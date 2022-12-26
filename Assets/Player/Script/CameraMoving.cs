using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoving : MonoBehaviour
{
    // Start is called before the first frame update
    Transform player;
    public float posX= 7;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Dying").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 temp = transform.position;
            temp.z = player.position.z;
            temp.y = player.position.y + 2.015218f;
            temp.x = posX;
            transform.position = temp;
            
        }
    }
}
