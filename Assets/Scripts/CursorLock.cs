using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorLock : MonoBehaviour
{

    public GameObject reload;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if( Input.GetKey(KeyCode.Escape) )
        {
            if (Cursor.lockState == CursorLockMode.Locked)
            {
                Cursor.lockState = CursorLockMode.None;
                reload.SetActive(true);     // Activates the restart button
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                reload.SetActive(false);     // Dectivates the restart button
            }
        }
    }
}
