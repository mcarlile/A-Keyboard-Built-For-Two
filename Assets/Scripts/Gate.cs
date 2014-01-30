using UnityEngine;
using System.Collections;

public class Gate : MonoBehaviour
{

		public Color openColor;
		public Color closedColor;
		public string keyCode;
		public GameObject aBox;
		public GameObject bBox;
		public GameObject cBox;
		public GameObject dBox;
	
	
		// Use this for initialization
		void Start ()
		{
				aBox.gameObject.renderer.material.SetColor ("_Color", closedColor);
				bBox.gameObject.renderer.material.SetColor ("_Color", closedColor);
				cBox.gameObject.renderer.material.SetColor ("_Color", closedColor);
				dBox.gameObject.renderer.material.SetColor ("_Color", closedColor);
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKey (KeyCode.A)) {
						aBox.renderer.material.SetColor ("_Color", openColor);
						aBox.gameObject.collider.isTrigger = true;
				} else {
						aBox.renderer.material.SetColor ("_Color", closedColor);
						aBox.gameObject.collider.isTrigger = false;
				}
		
				if (Input.GetKey (KeyCode.B)) {
						bBox.renderer.material.SetColor ("_Color", openColor);
						bBox.gameObject.collider.isTrigger = true;
				} else {
						bBox.renderer.material.SetColor ("_Color", closedColor);
						bBox.gameObject.collider.isTrigger = false;
				}

				if (Input.GetKey (KeyCode.C)) {
						cBox.renderer.material.SetColor ("_Color", openColor);
						cBox.gameObject.collider.isTrigger = true;
				} else {
						cBox.renderer.material.SetColor ("_Color", closedColor);
						cBox.gameObject.collider.isTrigger = false;
				}

				if (Input.GetKey (KeyCode.D)) {
						dBox.renderer.material.SetColor ("_Color", openColor);
						dBox.gameObject.collider.isTrigger = true;
				} else {
						dBox.renderer.material.SetColor ("_Color", closedColor);
						dBox.gameObject.collider.isTrigger = false;
				}
		}
	
}
