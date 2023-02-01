using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    [SerializeField] private GameObject _buttonEasy;
    [SerializeField] private GameObject _buttonMedium;
    [SerializeField] private GameObject _buttonHard;
    [SerializeField] private GameObject _start;
    [SerializeField] private GameObject _panelChooseLevel;
    [SerializeField] private GameObject _panelStart;
    
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void ChooseEasyLevel()
    {
        GameData.SpeedBall = 7;
        GameData.SpeedObstacle = 7;
        _panelChooseLevel.SetActive(false);
        _panelStart.SetActive(true);
    } 
    public void ChooseMediumLevel()
    {
        GameData.SpeedBall = 12;
        GameData.SpeedObstacle = 12;
        _panelChooseLevel.SetActive(false);
        _panelStart.SetActive(true);
    } 
    public void ChooseHardLevel()
    {
        GameData.SpeedBall = 16;
        GameData.SpeedObstacle = 16;
        _panelChooseLevel.SetActive(false);
        _panelStart.SetActive(true);
    } 
}
