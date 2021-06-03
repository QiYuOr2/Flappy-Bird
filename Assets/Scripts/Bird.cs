using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {

    Rigidbody2D rigidBody;

    public AudioClip fly;
    public AudioClip collide;
    public AudioClip score;

    // 用来播放音乐
    private AudioSource source;

    // 向上的速度
    public int jumpHeight = 5;

    // Use this for initialization
    void Start() {
        source = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (GameManager.isActive) {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {
                // 向上跳
                source.PlayOneShot(fly);
                rigidBody.velocity = new Vector3(0, jumpHeight, 0);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.tag == "Obstacle") {
            source.PlayOneShot(collide);
        }
    }

    void OnTriggerExit2D(Collider2D collider) {
        if (collider.gameObject.tag == "Obstacle" && GameManager.isActive) {
            source.PlayOneShot(score);
        }
    }
}
