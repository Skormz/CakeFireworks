using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinScreen : MonoBehaviour
{
    public GameObject Win;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Winner();
    }


    void Winner()
    {
        Win.SetActive(true);
        PauseGame();
    }


    private void PauseGame()
    {
        Time.timeScale = 0.0f;


        //Disable scripts that still work while timescale is set to 0
    }
}
