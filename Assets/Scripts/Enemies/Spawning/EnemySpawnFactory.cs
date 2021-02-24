using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnFactory : MonoBehaviour
{
    [Header("Time from spawn first to spawn next enemy")]
    [SerializeField] private float _remeaning = 2f;
    private float _ellapsed = 0f;
    private EnemySpawner[] _spawners;
    private uint _currentSpawner = 0;

    void Start()
    {
        _spawners = FindObjectsOfType<EnemySpawner>();

        if(_spawners.Length > 0)
            SpawnEnemy();
    }

    void Update()
    {
        _ellapsed += Time.deltaTime;

        if (_ellapsed >= _remeaning)
        {
            SpawnEnemy();
            _ellapsed = 0f;
        }
    }

    private void SpawnEnemy()
    {
        _spawners[_currentSpawner].SpawnEnemy(_spawners[_currentSpawner].transform.position);
        _currentSpawner++;
        if (_currentSpawner == _spawners.Length)
            _currentSpawner = 0;
    }
}
