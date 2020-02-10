using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour
{
    public float autoScrollSpeed;
    public float startTimer = 3f;

    private GameObject cameraPosition;
    private bool gameStart;
    
    
    
    void Awake()
    {
        
    }

    void Update()
    {
        startTimer = startTimer -= Time.deltaTime;

        if (startTimer <= 0)
        {
            gameStart = true;
        }

        if (gameStart == true)
        {
            transform.Translate(autoScrollSpeed, 0f, 0f);
        }
        
    }

}
