using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector3.left * speed *Time.deltaTime);
    }
}
