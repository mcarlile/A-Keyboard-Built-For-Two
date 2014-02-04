using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour
{

		public Color openColor;
		public Color closedColor;
		public GameObject player2winsleft;
		public GameObject player2winsright;
		public GameObject player1winsleft;
		public GameObject player1winsright;
		public bool gameOver = false;
		public AudioClip gateSound;
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
	
		// Use this for initialization
		void Start ()
		{
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
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKey (KeyCode.A)) {
						foreach (GameObject box in aBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in aBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.B)) {
						foreach (GameObject box in bBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in bBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.C)) {
						foreach (GameObject box in cBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in cBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.D)) {
						foreach (GameObject box in dBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in dBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.E)) {
						foreach (GameObject box in eBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in eBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.F)) {
						foreach (GameObject box in fBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in fBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.G)) {
						foreach (GameObject box in gBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in gBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.H)) {
						foreach (GameObject box in hBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in hBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.I)) {
						foreach (GameObject box in iBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in iBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.J)) {
						foreach (GameObject box in jBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in jBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.K)) {
						foreach (GameObject box in kBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in kBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.L)) {
						foreach (GameObject box in lBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in lBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.M)) {
						foreach (GameObject box in mBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in mBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.N)) {
						foreach (GameObject box in nBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in nBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.O)) {
						foreach (GameObject box in oBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in oBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.P)) {
						foreach (GameObject box in pBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in pBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.Q)) {
						foreach (GameObject box in qBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in qBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.R)) {
						foreach (GameObject box in rBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in rBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.S)) {
						foreach (GameObject box in sBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in sBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.T)) {
						foreach (GameObject box in tBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in tBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}
				if (Input.GetKey (KeyCode.U)) {
						foreach (GameObject box in uBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in uBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.V)) {
						foreach (GameObject box in vBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in vBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.W)) {
						foreach (GameObject box in wBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in wBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.X)) {
						foreach (GameObject box in xBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in xBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.Y)) {
						foreach (GameObject box in yBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in yBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}

				if (Input.GetKey (KeyCode.Z)) {
						foreach (GameObject box in zBoxes) {
								box.renderer.material.SetColor ("_Color", openColor);
								box.gameObject.collider.isTrigger = true;
								PlaySound ();
						}
				} else {
						foreach (GameObject box in zBoxes) {
								box.renderer.material.SetColor ("_Color", closedColor);
								box.gameObject.collider.isTrigger = false;
						}
				}	
		
		}
	
		public void PlaySound ()
		{
				audio.PlayOneShot (gateSound, 0.7F);
		}

		public void Player1Wins ()
		{
				if (!gameOver) {
						player1winsleft.SetActive (true);
						player1winsright.SetActive (true);
				}
			
		}

		public void Player2Wins ()
		{
				if (!gameOver) {
						player2winsleft.SetActive (true);
						player2winsright.SetActive (true);
				}
		}
	
}
