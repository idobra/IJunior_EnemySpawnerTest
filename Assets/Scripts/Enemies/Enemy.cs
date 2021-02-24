using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    public float MoveSpeed => _moveSpeed;
}
