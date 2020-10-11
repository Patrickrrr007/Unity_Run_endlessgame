using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		/*if (other.tag == "player") 
		{
			//Application.LoadLevel (1);

			Debug.Break ();
		}*/

		if (other.gameObject.transform.parent) {
			Destroy (other.gameObject.transform.parent.gameObject);
		} else 
		{
			Destroy (other.gameObject);
		}
	}
}  