using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [SerializeField] GameObject e;
    bool spawnEnemy = true;

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
        if (spawnEnemy)
        {
            float spawnX = Random.Range(38, 84);
            float SpawnY = 1.454f;
            Vector2 spawnPos = new Vector2(spawnX, SpawnY);
            Instantiate(e, spawnPos, Quaternion.identity);
        }


    }
}
