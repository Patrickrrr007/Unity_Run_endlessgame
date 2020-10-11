using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDownScript : MonoBehaviour {

	HUD hud;
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			hud = GameObject.Find ("Main Camera").GetComponent<HUD> ();
			hud.IncreaseScore (-10);
			Destroy (this.gameObject);
		}
	}

}
