using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]private GameObject _enemyPrefab;

    public void SpawnEnemy(Vector3 spawnPosition)
    {
        Instantiate(_enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
