using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    void Start()
    {
        pausePanel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausePanel.activeInHierarchy == false)
            {
                PauseGame();
            }
            if (pausePanel.activeInHierarchy == true)
            {
                ContinueGame();
            }
        }
    }
    private void PauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0.0f;
        
        
        //Disable scripts that still work while timescale is set to 0
    }
    private void ContinueGame()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1.0f;
        
        
        //enable the scripts again
    }
}
