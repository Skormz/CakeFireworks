using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Damage Taken");

        if (health <= 0)
        {
            //gameover
            Debug.Log("Gameover");
        }
    }   
}
