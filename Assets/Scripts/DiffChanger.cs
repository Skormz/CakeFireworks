using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiffChanger : MonoBehaviour
{
    public GameObject Difficulty;
    public int setting;

    public void Changer()
    {
        Difficulty.SendMessage("ChangeSet", setting, SendMessageOptions.DontRequireReceiver);
    }
}
