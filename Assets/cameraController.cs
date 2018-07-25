﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

	public GameObject target;
	float desiredDistance = 4f;

	float pitch = 0f;
	float pitchMin = 40f;
	float pitchMax = 60f;
	float yaw = 0f;
	float roll = 0f;

	float sensitivity = 15f;
	
	// Update is called once per frame
	void Update () {

		pitch -= sensitivity * Input.GetAxis ("Mouse Y");

		pitch = Mathf.Clamp (pitch, pitchMin, pitchMax);

		yaw += sensitivity * Input.GetAxis ("Mouse X");

		transform.localEulerAngles = new Vector3 (pitch, yaw, roll);
		transform.position = target.transform.position - desiredDistance * transform.forward + Vector3.up * 1.5f;
	}
}
