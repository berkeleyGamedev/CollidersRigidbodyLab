﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTask1: MonoBehaviour {

	public float movespeed;
	public float maxspeed;
	public float jumpforce;

	int FloorLayer;

	Rigidbody2D playerRB;

	//TASK 1 (PAY ATTENTION)
	bool canJump;


	void Awake() {
		FloorLayer = LayerMask.NameToLayer ("Floor");
		playerRB = gameObject.GetComponent<Rigidbody2D> ();
	}

	void Update () {
		//Movement
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


		//TASK 1: If someone pushes the space button and?
		if (Input.GetKeyDown(KeyCode.Space)) {
			playerRB.linearVelocity = new Vector2 (playerRB.linearVelocity.x, 0);
			playerRB.AddForce ( new Vector2(0, jumpforce));
		}
	}
	// Returns if the given GameObject is a floor, platform, or wall
	bool isFloor(GameObject obj) {
		return obj.layer == FloorLayer;
	}

    // This function is called whenever the Collider2D attached to the gameobject comes into contact with another collider
    // use coll.gameObject if you need a reference coll's GameObject
    void OnCollisionEnter2D(Collision2D coll) {
        //TASK 1
	}

	// This function is called whenever the Collider2D attached to the gameobject leaves contact with another collider
	void OnCollisionExit2D(Collision2D coll) {
        //TASK 1
	}
}
