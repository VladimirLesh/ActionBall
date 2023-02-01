using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SpownBallPoint : MonoBehaviour
{
    [SerializeField] private Ball _ball;

    private void Start()
    {
        Invoke("SpownBall", 2f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            GameData.Score++;
            Debug.Log(GameData.Score);
        }
    }

    private void SpownBall()
    {
        Instantiate(_ball, transform.position, quaternion.identity);
    }

    
}
