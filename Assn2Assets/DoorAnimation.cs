﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour {

    public float SPEED = 1.0F;  // rotation speed
    private int stopAngle;
    private Vector3 direction;

	// Use this for initialization
	void Start () {
        stopAngle = (int)transform.eulerAngles.y; // stay in the current position
	}
	
	// Update is called once per frame
	void Update () {
        if ((int)transform.eulerAngles.y != stopAngle) // rotate untill current angle != stop angle
        {
            transform.Rotate(direction * SPEED);
        }

        // Right mouse button keys
        if (Input.GetMouseButtonDown(1))
        {
            if (stopAngle == 0)
            {
                stopAngle = 90;              // stop angle 90
                direction = Vector3.up;  // direction around Y clock-wise
            }
            else if (stopAngle == 90)
            {
                stopAngle = 0;              // stop angle 0
                direction = -Vector3.up;  // direction around Y counter clockwise
            }
        }
    }
}
