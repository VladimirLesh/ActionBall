using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameInspector : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    void Start()
    {
        StartCoroutine(ReadyToPlay());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ReadyToPlay()
    {yield return new WaitForEndOfFrame();
        for (int i = 3; i > 0; i--)
        {
            _text.text = $"{i}";
            yield return new WaitForSeconds(1);
        }
        _text.enabled = false;
        GameData.IsPlay = true;
    }
}
