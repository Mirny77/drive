﻿using System.Collections;
using UnityEngine;

[RequireComponent (typeof (CarLights))]
[RequireComponent (typeof (MoveCar))]
public class WestTurnRight : MonoBehaviour {

	private Rigidbody rb;
	private float eulerAngleVelocity;

	void Start () {
		rb = GetComponent <Rigidbody> ();
		GetComponent <CarLights> ().showObject = 0;
	}

	void FixedUpdate () {
		leftTurn ();
	}

	void leftTurn () {
		float carRotation = Mathf.Floor (transform.eulerAngles.y);
		if (transform.localPosition.x > -15f && carRotation != 0f) {
			if (carRotation >= -1f && carRotation <= 4f) {
				transform.localRotation = Quaternion.Euler (new Vector3 (0, 0f, 0));
				return;
			}
			eulerAngleVelocity = GetComponent <MoveCar> ().speed * 8.57f;
			Quaternion deltaRotation = Quaternion.Euler (new Vector3 (0, eulerAngleVelocity, 0) * Time.fixedDeltaTime);
			rb.MoveRotation (rb.rotation * deltaRotation);
		}
	}

}
