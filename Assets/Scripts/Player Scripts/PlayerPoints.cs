using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPoints : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals ("Cake"))
        {
            manager.SendMessage("AddPoints",collision.gameObject.GetComponent<Cake>().cakeValue);
            Destroy(collision.gameObject);
        }
    }
}
