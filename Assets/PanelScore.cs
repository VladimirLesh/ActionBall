using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelScore : MonoBehaviour
{
    [SerializeField] private TMP_Text _countScore;
    [SerializeField] private TMP_Text _countTime;
    [SerializeField] private TMP_Text _countTry;

    private int min;
    private int sec;

    private void Start()
    {
        _countScore.text = GameData.Score.ToString();
        GetTime();
        _countTime.text = $"{min}.{sec}";
        _countTry.text = GameData.Try.ToString();
    }

    private void GetTime()
    {
        min = Convert.ToInt32(GameData.Time / 60);
        sec = Convert.ToInt32(GameData.Time % 60);
    }
}
