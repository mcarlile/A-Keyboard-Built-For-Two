using UnityEngine;
using System.Collections;
using McKenzie_Carlile;

public class DoNotDestroy : MonoBehaviour
{
	
		private static DoNotDestroy instance = null;
		public static DoNotDestroy Instance {
				get { return instance; }
		}
		void Awake ()
		{
				if (instance != null && instance != this) {
						Destroy (this.gameObject);
						return;
				} else {
						instance = this;
				}
				DontDestroyOnLoad (this.gameObject);
		}
	
		// any other methods you need
}