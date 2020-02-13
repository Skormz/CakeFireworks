using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
            transform.Translate (Vector2.right * speed * Time.deltaTime);
    }

}
