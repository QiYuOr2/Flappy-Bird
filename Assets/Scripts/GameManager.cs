using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    // 分数
    public static int score = 0;
    public static int historyScore = 0;

    // 正在游戏中
    public static bool isActive = true;

    // 是否是重新开始
    public static bool isRestart = false;

    // Use this for initialization
    void Start() {
        Screen.SetResolution(480, 800, false);
        if (!isRestart) {
            Time.timeScale = 0;
        }
    }

    // Update is called once per frame
    void Update() {

    }
}
