using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score;
   // public GameObject[] fireworks;
   // public GameObject spawnPoint;
   // public Vector2 fireworkSpawnValues;
   // public int fireworkCount;
   // public float spawnWait;
   // public float startWait;
   // public float waveWait;

    void Start()
    {
        score = 0;
       // StartCoroutine (SpawnFireworks());
    }

    void AddPoints(int amount)
    {
        score += amount;
    }

   /* IEnumerator SpawnFireworks()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < fireworkCount; i++)
            {
                GameObject firework = fireworks[Random.Range(0, fireworks.Length)];
                Vector2 spawnPosition = new Vector2(Random.Range(-fireworkSpawnValues.y, fireworkSpawnValues.y), fireworkSpawnValues.x);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate (firework, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(waveWait);
            }
            yield return new WaitForSeconds(waveWait);
        }
    }*/

}
