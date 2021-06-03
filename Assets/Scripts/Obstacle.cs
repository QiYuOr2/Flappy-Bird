using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {

	public float speed = 0.05f;

	// Use this for initialization
	void Start () {
		Destroy(gameObject, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.isActive) {
			transform.Translate(Vector3.left * speed * Time.deltaTime);
		}
    }

	void OnTriggerExit2D(Collider2D collider) { 
		if (collider.gameObject.tag == "Player" && GameManager.isActive) {
			GameManager.score += 1;
        }
	}
}
