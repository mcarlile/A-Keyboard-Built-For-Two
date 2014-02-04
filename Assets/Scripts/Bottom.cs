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
				if (otherCollider.gameObject.name.Contains ("Ball1")) {
						manager.GetComponent<Manager> ().Player1EnteredFirst ();
				}

				if (otherCollider.gameObject.name.Contains ("Ball2")) {
						manager.GetComponent<Manager> ().Player2EnteredFirst ();
				}
		}
}
