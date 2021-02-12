using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour {

	public GameObject coinpre;
	public float shotSpeed;
	public float shotTorque;

	public float baseWidth;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown ("Fire1"))
			Shot ();
		
	}

	Vector3 GetInstantiatePosition(){
		float x = baseWidth * (Input.mousePosition.x / Screen.width) - (baseWidth / 2);
		return transform.position+new Vector3(x,0,0);
	}


	public void Shot(){
		GameObject coin = (GameObject)Instantiate (coinpre, GetInstantiatePosition(), Quaternion.identity);

		Rigidbody candyRigidBody = coin.GetComponent<Rigidbody> ();
		candyRigidBody.AddForce (transform.forward * shotSpeed);
		candyRigidBody.AddTorque (new Vector3 (0, shotTorque, 0));
	}
}
