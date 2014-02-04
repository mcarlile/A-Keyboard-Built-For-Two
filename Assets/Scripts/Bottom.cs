using UnityEngine;
using System.Collections;
using McKenzie_Carlile;

public class Bottom : MonoBehaviour
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
				manager.GetComponent<Manager> ().HidePlayerNumbers ();
				

		
				if (otherCollider.gameObject.name.Contains ("Ball1")) {
						manager.GetComponent<Manager> ().Player1EnteredFirst ();
						manager.GetComponent<Manager> ().ShowInstructions ();
				}

				if (otherCollider.gameObject.name.Contains ("Ball2")) {
						manager.GetComponent<Manager> ().Player2EnteredFirst ();
						manager.GetComponent<Manager> ().ShowInstructions ();
				}
		}

		void OnTriggerStay (Collider otherCollider)
		{
				if (Input.GetKeyDown (KeyCode.Escape)) {
						if (otherCollider.gameObject.name.Contains ("Ball")) {
								Application.LoadLevel (2);
						}
				}
		
				if (Input.GetKeyDown (KeyCode.Space)) {
						if (otherCollider.gameObject.name.Contains ("Ball")) {
								Application.LoadLevel (1);
								Debug.Log ("tried to reload level");
						}
				}
		}
}
	

