﻿using UnityEngine;
using System.Collections;
using McKenzie_Carlile;

public class Credits : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.Escape)) {
						Application.LoadLevel (0);
				}
		}
}
