using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour {
	public GameObject obstacle;

	// 生成障碍的间隔
	public float interval = 2f;
	// 下次生成障碍的时间
	float nextObstacleTime = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.isActive) {
			if (Time.time > nextObstacleTime) {
				nextObstacleTime = Time.time + interval;

				Vector3 obstaclePosition = transform.position;
				// y 可生成范围 2.83 ~ -1.06
				obstaclePosition.y += Random.Range(-1.06f, 2.83f);
				Instantiate(obstacle, obstaclePosition, transform.rotation);
			}
		}
	}
}
