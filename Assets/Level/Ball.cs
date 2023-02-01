using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rigidbody;
    private Vector2 _position;
    private float _maxHeightBall;

    private void Start()
    {
        _maxHeightBall = 4;
        _rigidbody = GetComponent<Rigidbody2D>();
        GameData.LastSpeedBall = GameData.SpeedBall;
        StartCoroutine(SpeedUp());
    }

    private void Update()
    {
        if (GameData.IsPlay)
        {
            if (Input.GetKey(KeyCode.UpArrow)) MoveUp();
            else Move();

            GameData.Time += Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out Obstacle obstacle))
        {
            SceneManager.LoadScene(2);
            GameData.IsPlay = false;
            GameData.Try++;
        }
    }

    private void MoveUp()
    {
        if (transform.position.y < _maxHeightBall)
        {
            _rigidbody.MovePosition(transform.position + transform.up * GameData.SpeedBall * Time.fixedDeltaTime);
        }
    }
    
    private void Move()
    {
        if (transform.position.y > -_maxHeightBall)
        {
            _rigidbody.MovePosition(transform.position - transform.up * GameData.SpeedBall * Time.fixedDeltaTime);
        }
    }

    IEnumerator SpeedUp()
    {
        yield return new WaitForSeconds(15);
        while (GameData.IsPlay)
        {
            GameData.SpeedBall += 5;
            yield return new WaitForSeconds(15);
        }
    }
}
