using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuReturn : MonoBehaviour
{
    GameObject DeleteMe;
    public void LoadLevel(string scenename)
    {
        DeleteMe = GameObject.Find("Difficulty");
        Destroy(DeleteMe);
        SceneManager.LoadScene(scenename);
    }
}
