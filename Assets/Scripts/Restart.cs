using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {
    public GameObject gameOver;
    public void Click() {
        // 分数清空，改为正在游戏状态，隐藏gameover框
        GameManager.score = 0;
        GameManager.isActive = true;
        gameOver.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
