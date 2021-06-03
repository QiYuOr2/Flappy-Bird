﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Text score;
    public Text historyScore;
    public GameObject gameOver;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        score.text = GameManager.score.ToString();
        historyScore.text = "最高分：" + GameManager.historyScore.ToString();

        if (!GameManager.isActive) {
            gameOver.SetActive(true);
        }
    }
}
