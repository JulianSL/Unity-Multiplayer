﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerController : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!isLocalPlayer)
        {
            return;
        }
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * 3;
        var y = Input.GetAxis("Vertical") * Time.deltaTime * 3;
        
        transform.Translate(x, y, 0);
    }
}
