using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillVolume : MonoBehaviour
{
    public GameObject Game_Over;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameOver();
    }


    void GameOver()
    {
        Game_Over.SetActive(true);
        PauseGame();
    }


    private void PauseGame()
    {
        Time.timeScale = 0.0f;


        //Disable scripts that still work while timescale is set to 0
    }

}

