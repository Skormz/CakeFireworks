using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    int colorSel;
    // Start is called before the first frame update
    void Start()
    {
        colorSel = Random.Range(1, 4);
        if(colorSel == 1)
            GetComponent<SpriteRenderer>().color = Color.red;
        else if (colorSel == 2)
            GetComponent<SpriteRenderer>().color = Color.green;
        else if (colorSel == 3)
            GetComponent<SpriteRenderer>().color = Color.blue;

        Destroy(gameObject, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
