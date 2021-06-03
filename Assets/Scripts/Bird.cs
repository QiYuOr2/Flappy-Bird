using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    Rigidbody2D rigidBody;

    // 向上的速度
    public int jumpHeight = 5;

    // Use this for initialization
    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (GameManager.isActive) {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
                // 向上跳
                rigidBody.velocity = new Vector3(0, jumpHeight, 0);
            }
        }
    }
}
