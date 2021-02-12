using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pusher : MonoBehaviour {

	Vector3 startPosition;

	public float ampltude=2.0f;
	public float speed=0.5f;


	// Use this for initialization
	void Start () {
		startPosition = transform.localPosition;
	}

	// Update is called once per frame
	void Update () {
		float z = ampltude * Mathf.Sin (Time.time * speed);
		transform.localPosition = startPosition + new Vector3 (0, 0, z);
	}
}
