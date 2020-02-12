using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firework : MonoBehaviour
{
    public float movementSpeed = 0.1f;

    void Awake()
    {

    }

    void Update()
    {
            transform.Translate(-movementSpeed, 0f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
    }

}
