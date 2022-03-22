using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public AbstractLevel Level;
    public float secondBetweenEnemies;
    private float lastEnemySpawnTime;
    private AbstractEnemyGenerator EnemyGenerator;

    void Start()
    {
        lastEnemySpawnTime = Time.time;
        EnemyGenerator = Level.GetEnemyGenerator();
    }


    void Update()
    {
        if (Time.time >= lastEnemySpawnTime + secondBetweenEnemies) {
            lastEnemySpawnTime = Time.time;
            EnemyGenerator.SpawnEnemy();
        }
    }
}
