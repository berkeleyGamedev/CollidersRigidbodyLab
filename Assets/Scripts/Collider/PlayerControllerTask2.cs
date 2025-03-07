﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTask2 : MonoBehaviour {

	public float movespeed;
	public float maxspeed;
	public float jumpforce;

	int FloorLayer;

	Rigidbody2D playerRB;

	//TASK 2
	public bool feetContact;

	void Awake() {
		playerRB = gameObject.GetComponent<Rigidbody2D> ();
	}

	void Update () {
		float MoveHor = Input.GetAxisRaw ("Horizontal");
		Vector2 movement = new Vector2 (MoveHor * movespeed, 0);
		movement = movement * Time.deltaTime;

		playerRB.AddForce(movement);
		if (playerRB.linearVelocity.x > maxspeed) {
			playerRB.linearVelocity = new Vector2 (maxspeed, playerRB.linearVelocity.y);
		}
		if (playerRB.linearVelocity.x < -maxspeed) {
			playerRB.linearVelocity = new Vector2 (-maxspeed, playerRB.linearVelocity.y);
		}
		if (Input.GetKeyDown(KeyCode.Space) && canJump()) {
			playerRB.linearVelocity = new Vector2 (playerRB.linearVelocity.x, 0);
			playerRB.AddForce ( new Vector2(0, jumpforce));
		}

	}

	bool canJump() {
        return false;
		//TASK 2
	}
}
