using UnityEngine;
using System.Collections;
using McKenzie_Carlile;

public class StartTrigger : MonoBehaviour
{
		public GameObject manager;
		public GameObject startTrigger2;
		public bool allowStart = false;

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
						manager.GetComponent<Manager> ().BallOneInPosition ();

				}

				if (otherCollider.gameObject.name.Contains ("Ball2")) {
						manager.GetComponent<Manager> ().BallTwoInPosition ();
				}
		}
}
