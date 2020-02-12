using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject firework;

    void Start()
    {
        Instantiate(firework, transform.position, Quaternion.identity);
    }
}
