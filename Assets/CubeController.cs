using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public float speed=-1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Translate(0,speed*Time.deltaTime,0,Space.World); 
       transform.Rotate(Vector3.one); 
    }
}
