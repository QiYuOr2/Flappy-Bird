using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour {
    public GameObject gameOver;
    public Button startButton;

    void Start() {
        if (GameManager.isRestart) {
            startButton.gameObject.SetActive(false);
        }
    }

    public void Play() {
        Time.timeScale = 1;
        startButton.gameObject.SetActive(false);
    }
    public void Restart() {
        GameManager.score = 0;
        GameManager.isActive = true;
        GameManager.isRestart = true;
        gameOver.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
