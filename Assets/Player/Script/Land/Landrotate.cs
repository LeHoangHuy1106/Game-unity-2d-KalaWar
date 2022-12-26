using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landrotate : MonoBehaviour
{
    float rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = Random.Range(1,3);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rd, 0f, 0f);   
    }
}
