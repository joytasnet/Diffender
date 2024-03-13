using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //isTriggerコライダーがあり、どちらかにrigidbodyがついているものが
    //接触した場合OnTriggerEnterが走る
    //引数には衝突してきたcolliderが入る
    void OnTriggerEnter(Collider other) {
        //Debug.Log(other.gameObject.name);
        Debug.Log("GameOver");
    }
}
