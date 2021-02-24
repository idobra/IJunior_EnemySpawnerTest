using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyMover : MonoBehaviour
{
    private Target _target;
    private Enemy _enemy;

    private void OnEnable()
    {
        _target = FindObjectOfType<Target>();
        _enemy = GetComponent<Enemy>();

        if (_target != null)
            _target.OnReached += OnRiched;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.gameObject.transform.position, _enemy.MoveSpeed * Time.deltaTime);
    }

    private void OnDisable()
    {
        if (_target != null)
            _target.OnReached -= OnRiched;
    }

    private void OnRiched(Enemy enemy)
    {
        Destroy(enemy.gameObject);
    }
}
