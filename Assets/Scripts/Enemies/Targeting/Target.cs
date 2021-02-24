using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class Target : MonoBehaviour
{
    public delegate void OnReachedHandler(Enemy reachedObject);
    public event OnReachedHandler OnReached;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out Enemy enemy))
            OnReached.Invoke(enemy);
    }
}
