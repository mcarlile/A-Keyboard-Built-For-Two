﻿using UnityEngine;
using System.Collections;

public class DoNotDestroy : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				DontDestroyOnLoad (this.gameObject);
		}
}