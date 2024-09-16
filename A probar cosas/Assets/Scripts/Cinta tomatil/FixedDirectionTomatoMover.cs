using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedDirectionTomatoMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _direction;
    public bool IsBadTomato;

    private Transform _mTransform;

    public void SetSpeedAndDirection(float speed, Vector2 direction)
    {
        _direction = direction;
        _speed = speed;
    }

    private void Awake()
    {
        _mTransform = transform;
    }

    private void Update()
    {
        _mTransform.position += (Vector3)_direction * _speed * Time.deltaTime;
    }
}
