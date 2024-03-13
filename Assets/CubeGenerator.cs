using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
    public GameObject cubePrefab;
    public float span = 1f;
    float delta = 0f;

    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span){
            delta = 0f;
            Instantiate(
                cubePrefab,
                new Vector3(
                    Random.Range(-2f,2f),
                    Random.Range(4f,6f),
                    0f
                ),
                Quaternion.identity
            );
        }
        
    }
}
