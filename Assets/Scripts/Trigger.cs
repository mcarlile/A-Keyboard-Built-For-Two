﻿using UnityEngine;
using System.Collections;

using McKenzie_Carlile;

public class Trigger : MonoBehaviour
{
		public GameObject manager;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnTriggerEnter (Collider otherCollider)
		{
				if (otherCollider.gameObject.name.Contains ("Ball")) {
						manager.GetComponent<Manager> ().ShowPlayerNumbers ();
				}
	
		}
}
