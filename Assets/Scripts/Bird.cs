using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    Rigidbody2D rigidBody;

    // 向上的力度
    public float upForce = 200f;

    // Use this for initialization
    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
            rigidBody.AddForce(Vector2.up * upForce);
        }
    }
}
