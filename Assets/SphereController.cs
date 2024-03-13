using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(Vector3.up*500f);
        rb.velocity = Vector3.up * 10f;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump")){
            //rb.AddForce(Vector3.right * 300f);
            rb.velocity=Vector3.right * 10f;

            /*
            Vector3.zero : new Vector3(0f,0f,0f)
            Vector3.one : new Vector3(1f,1f,1f)
            Vector3.up : new Vector3(0f,1f,0f)
            Vector3.right : new Vector3(1f,0f,0f)
            */
        }
        
    }
}
