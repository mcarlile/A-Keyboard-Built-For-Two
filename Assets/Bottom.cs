using UnityEngine;
using System.Collections;

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
						manager.GetComponent<Manager> ().Player1Wins ();
				}

				if (otherCollider.gameObject.name.Contains ("Ball2")) {
						manager.GetComponent<Manager> ().Player2Wins ();
				}
		}
}
