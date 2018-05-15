﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationOfMovement : MonoBehaviour {

    public Animator anim;
    

    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("w"))
        {
            anim.Play("running");
        }
        if(Input.GetKeyUp("w"))
        {
            anim.Play("forwardstop");
        }
    }
}