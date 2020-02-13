using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 3;
    private GameObject Difficulty;
    private int diffsetting;
    public GameObject[] Hearts;
    public GameObject[] LostHearts;
    public GameObject Game_Over;
    

    private void Start()
    {
        Difficulty = GameObject.Find("Difficulty");
        HealthSetter();
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Damage Taken");
        Hearts[health].SetActive(false);
        LostHearts[health].SetActive(true);
        if (health <= 0)
        {
            GameOver();
        }
    } 
    
    void GameOver()
    {
        Game_Over.SetActive(true);
        PauseGame();
    }

    private void HealthSetter()
    {
        Difficulty.GetComponent<DifficultySetter>();
        diffsetting = DifficultySetter.DiffSetting;
        
            if (diffsetting == 1)
            {
                health = 5;
            }

            else if (diffsetting == 3)
            {
                health = 1;
            }
        for (int i = 0; i < health; ++i)
        {
            Hearts[i].SetActive(true);
        }
 
    }
    private void PauseGame()
    {
        Time.timeScale = 0.0f;


        //Disable scripts that still work while timescale is set to 0
    }
}
