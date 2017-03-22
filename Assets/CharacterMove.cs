﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
	public float speed = 3f;
	void Update ()
	{
		var pos = transform.position;
		if (Input.GetKey (KeyCode.RightArrow)) {
			pos.x += speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			pos.x -= speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			pos.y += speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			pos.y -= speed * Time.deltaTime;
		}
		transform.position = pos;
	}
}
