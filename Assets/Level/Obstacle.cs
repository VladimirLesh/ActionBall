using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Start()
    {
    }

    private void Update()
    {
        if (GameData.IsPlay) MoveObstacle();

        if (transform.position.x < ObstacleController.Instance._minZ)
        {
            Destroy(gameObject);
        }
    }

    private void MoveObstacle()
    {
        transform.position -= Vector3.right * GameData.SpeedObstacle * Time.deltaTime;
    }
}