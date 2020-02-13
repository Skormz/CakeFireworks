using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firework : MonoBehaviour
{
    public float speed = 0.1f;
    public int damage = 1;
    public GameObject explosionPrefab;

    void Update()
    {
            transform.Translate (Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.SendMessage("TakeDamage", damage, SendMessageOptions.DontRequireReceiver);
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
