using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] GameObject e;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        if (e != null)
        {
            float spawnX = Random.Range(35.76f, 85.29f);
            float SpawnY = 1.454f;
            Vector2 spawnPos = new Vector2(spawnX, SpawnY);
            Instantiate(e, spawnPos, Quaternion.identity);
        }

    }
}
