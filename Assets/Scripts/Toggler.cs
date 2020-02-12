using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggler : MonoBehaviour
{

    public Button thisButton;
    public GameObject Toggles;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = thisButton.GetComponent<Button>();
        btn.onClick.AddListener(Toggle);
    }

    void Toggle()
    {
        Debug.Log("You have clicked the button!");
        if (Toggles.activeInHierarchy)
        {
            Toggles.SetActive(false);
        }
        else
        {
            Toggles.SetActive(true);
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
}