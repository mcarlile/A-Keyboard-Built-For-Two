﻿using UnityEngine;
using System.Collections;

namespace McKenzie_Carlile
{
		public class Manager : MonoBehaviour
		{

				public Color openColor;
				public Color closedColor;
				public Color readyColor;
				public GameObject player1Instructions;
				public GameObject player2Instructions;
				public GameObject startGate1;
				public GameObject startGate2;
				public GameObject player1indicator;
				public GameObject player2indicator;
				public GameObject player2winsleft;
				public GameObject player2winsright;
				public GameObject player1winsleft;
				public GameObject player1winsright;
				public bool gameOver = false;
				bool ball1InPosition = false;
				bool ball2InPosition = false;
				bool allowStart = false;
				public AudioClip gateSound;
				public GameObject[] spaceBoxes;
				public GameObject[] aBoxes;
				public GameObject[] bBoxes;
				public GameObject[] cBoxes;
				public GameObject[] dBoxes;
				public GameObject[] eBoxes;
				public GameObject[] fBoxes;
				public GameObject[] gBoxes;
				public GameObject[] hBoxes;
				public GameObject[] iBoxes;
				public GameObject[] jBoxes;
				public GameObject[] kBoxes;
				public GameObject[] lBoxes;
				public GameObject[] mBoxes;
				public GameObject[] nBoxes;
				public GameObject[] oBoxes;
				public GameObject[] pBoxes;
				public GameObject[] qBoxes;
				public GameObject[] rBoxes;
				public GameObject[] sBoxes;
				public GameObject[] tBoxes;
				public GameObject[] uBoxes;
				public GameObject[] vBoxes;
				public GameObject[] wBoxes;
				public GameObject[] xBoxes;
				public GameObject[] yBoxes;
				public GameObject[] zBoxes;
				public GameObject[] startBoxes;
	
				// Use this for initialization
				void Start ()
				{
						spaceBoxes = GameObject.FindGameObjectsWithTag ("Space");
						aBoxes = GameObject.FindGameObjectsWithTag ("A");
						bBoxes = GameObject.FindGameObjectsWithTag ("B");
						cBoxes = GameObject.FindGameObjectsWithTag ("C");
						dBoxes = GameObject.FindGameObjectsWithTag ("D");
						eBoxes = GameObject.FindGameObjectsWithTag ("E");
						fBoxes = GameObject.FindGameObjectsWithTag ("F");
						gBoxes = GameObject.FindGameObjectsWithTag ("G");
						hBoxes = GameObject.FindGameObjectsWithTag ("H");
						iBoxes = GameObject.FindGameObjectsWithTag ("I");
						jBoxes = GameObject.FindGameObjectsWithTag ("J");
						kBoxes = GameObject.FindGameObjectsWithTag ("K");
						lBoxes = GameObject.FindGameObjectsWithTag ("L");
						mBoxes = GameObject.FindGameObjectsWithTag ("M");
						nBoxes = GameObject.FindGameObjectsWithTag ("N");
						oBoxes = GameObject.FindGameObjectsWithTag ("O");
						pBoxes = GameObject.FindGameObjectsWithTag ("P");
						qBoxes = GameObject.FindGameObjectsWithTag ("Q");
						rBoxes = GameObject.FindGameObjectsWithTag ("R");
						sBoxes = GameObject.FindGameObjectsWithTag ("S");
						tBoxes = GameObject.FindGameObjectsWithTag ("T");
						uBoxes = GameObject.FindGameObjectsWithTag ("U");
						vBoxes = GameObject.FindGameObjectsWithTag ("V");
						wBoxes = GameObject.FindGameObjectsWithTag ("W");
						xBoxes = GameObject.FindGameObjectsWithTag ("X");
						yBoxes = GameObject.FindGameObjectsWithTag ("Y");
						zBoxes = GameObject.FindGameObjectsWithTag ("Z");
						startBoxes = GameObject.FindGameObjectsWithTag ("Start");

				}
	
				// Update is called once per frame
				void Update ()
				{
						if ((ball1InPosition == true) && (ball2InPosition == true)) {
								allowStart = true;
						}
			
						if ((Input.GetKey (KeyCode.G)) || (Input.GetKey (KeyCode.H))) {
								foreach (GameObject box in startBoxes) {
										box.renderer.material.SetColor ("_Color", readyColor);
					
								}

								if ((Input.GetKey (KeyCode.G)) && (Input.GetKey (KeyCode.H)) && (allowStart == true)) {
										foreach (GameObject box in startBoxes) {
												box.renderer.material.SetColor ("_Color", openColor);
												box.gameObject.collider.isTrigger = true;
												startGate1.gameObject.collider.isTrigger = true;
												startGate2.gameObject.collider.isTrigger = true;
										}
								}
						} else {
								foreach (GameObject box in startBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}
			
						if (Input.GetKeyDown (KeyCode.A)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.Space)) {
								foreach (GameObject box in spaceBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
					
								}
						} else {
								foreach (GameObject box in spaceBoxes) {
										box.renderer.material.SetColor ("_Color", Color.black);
										box.gameObject.collider.isTrigger = false;
								}
						}
			
						if (Input.GetKeyDown (KeyCode.A)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.A)) {
								foreach (GameObject box in aBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
									
								}
						} else {
								foreach (GameObject box in aBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.A)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.B)) {
								foreach (GameObject box in bBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in bBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.B)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.C)) {
								foreach (GameObject box in cBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in cBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.C)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.D)) {
								foreach (GameObject box in dBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in dBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.D)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.E)) {
								foreach (GameObject box in eBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in eBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.E)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.F)) {
								foreach (GameObject box in fBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in fBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.F)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.G)) {
								foreach (GameObject box in gBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in gBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.G)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.H)) {
								foreach (GameObject box in hBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in hBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.H)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.I)) {
								foreach (GameObject box in iBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in iBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.I)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.J)) {
								foreach (GameObject box in jBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in jBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.J)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.K)) {
								foreach (GameObject box in kBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in kBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.K)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.L)) {
								foreach (GameObject box in lBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in lBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.L)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.M)) {
								foreach (GameObject box in mBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in mBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.M)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.N)) {
								foreach (GameObject box in nBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in nBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.N)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.O)) {
								foreach (GameObject box in oBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in oBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.O)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.P)) {
								foreach (GameObject box in pBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in pBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.P)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.Q)) {
								foreach (GameObject box in qBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in qBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.Q)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.R)) {
								foreach (GameObject box in rBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in rBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.R)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.S)) {
								foreach (GameObject box in sBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in sBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.S)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.T)) {
								foreach (GameObject box in tBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in tBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.T)) {
								audio.PlayOneShot (gateSound);
						}
						if (Input.GetKey (KeyCode.U)) {
								foreach (GameObject box in uBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in uBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.U)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.V)) {
								foreach (GameObject box in vBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in vBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.V)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.W)) {
								foreach (GameObject box in wBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in wBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.W)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.X)) {
								foreach (GameObject box in xBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in xBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.X)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.Y)) {
								foreach (GameObject box in yBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in yBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}

						if (Input.GetKeyDown (KeyCode.Y)) {
								audio.PlayOneShot (gateSound);
						}

						if (Input.GetKey (KeyCode.Z)) {
								foreach (GameObject box in zBoxes) {
										box.renderer.material.SetColor ("_Color", openColor);
										box.gameObject.collider.isTrigger = true;
								}
						} else {
								foreach (GameObject box in zBoxes) {
										box.renderer.material.SetColor ("_Color", closedColor);
										box.gameObject.collider.isTrigger = false;
								}
						}	

						if (Input.GetKeyDown (KeyCode.Z)) {
								audio.PlayOneShot (gateSound);
						}
		
				}

				public void Player1EnteredFirst ()
				{
						
						if (!gameOver) {
								gameOver = true;
								player1winsleft.SetActive (true);
								player1winsright.SetActive (true);
						}
			
				}

				public void Player2EnteredFirst ()
				{
						if (!gameOver) {
								gameOver = true;

								player2winsleft.SetActive (true);
								player2winsright.SetActive (true);
						}
				}

				public void ShowPlayerNumbers ()
				{
						player1indicator.SetActive (true);
						player2indicator.SetActive (true);
				}

				public void HidePlayerNumbers ()
				{
						player1indicator.SetActive (false);
						player2indicator.SetActive (false);
				}

				public void ShowInstructions ()
				{
						player1Instructions.SetActive (true);
						player2Instructions.SetActive (true);
				}

				public void BallOneInPosition ()
				{
						ball1InPosition = true;
				}

				public void BallTwoInPosition ()
				{
						ball2InPosition = true;
				}
		
		
		}
}
