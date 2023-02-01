using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagerScore : MonoBehaviour
{
    [SerializeField] private GameObject _buttonTryAgain;
    [SerializeField] private GameObject _buttonChooseLevel;
    [SerializeField] private GameObject _panelScore;
    [SerializeField] private GameObject _panelChooseLevel;

    

    public void StartGame()
    {
        GameData.Time = 0;
        GameData.Score = 0;
        GameData.SpeedBall = GameData.LastSpeedBall;
        SceneManager.LoadScene(1);
    }

    public void ChooseLevel()
    {
        _panelChooseLevel.SetActive(true);
        _panelScore.SetActive(false);
    }
}
