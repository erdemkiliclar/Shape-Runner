using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int _score;
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void Awake()
    {
        _score = 0;
    }

    private void Update()
    {
        _scoreText.text = _score + "";
    }
}
