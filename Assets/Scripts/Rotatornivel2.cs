﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatornivel2 : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, 100, 0) * Time.deltaTime);
	}
}
