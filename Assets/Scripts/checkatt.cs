﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkatt : MonoBehaviour
{
 
    public bool exst;

    // Use this for initialization
    void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            exst = true;
        }
    }
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            exst = true;
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        exst = false;
    }
}
