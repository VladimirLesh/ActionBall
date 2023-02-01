using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private Obstacle _obstacle;
    [SerializeField] private int _distBetweenObstacle;
    public float _minZ;
    public static ObstacleController Instance;


    private void Start()
    {
        if (Instance != null)
        {
            Destroy(Instance);
            return;
        }
        Instance = this;

        if (GameData.SpeedObstacle == 16) _distBetweenObstacle = 1;
        StartCoroutine(InstObstacle());
    }

    private void Update()
    {
        
    }

    IEnumerator InstObstacle()
    {
        while (true)
        {
            yield return new WaitForSeconds(_distBetweenObstacle);
            CreateObstacle();
        }
    }

    private void CreateObstacle()
    {
        int randomPosY = Random.Range(-4, 4);
        Instantiate(_obstacle, new Vector3(9.5f, randomPosY, 0), quaternion.identity);
    }
}
