using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarController : MonoBehaviour
{
    public GameObject effect;
    public float barSpeed=1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x =Input.GetAxisRaw("Horizontal");
        if(transform.position.x + x < 3.0f
        && transform.position.x + x > -3.0f){
            transform.Translate(x*barSpeed*Time.deltaTime,0,0);

        }
    }
    void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Cube")){
            Instantiate(
                effect,
                other.transform.position,
                Quaternion.Euler(-90f,0,0)
                );
            Destroy(other.gameObject);
        }
    }
}
