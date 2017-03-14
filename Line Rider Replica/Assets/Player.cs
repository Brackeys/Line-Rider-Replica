using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public Rigidbody2D rb;

	void Update ()
	{
		if (Input.GetButtonDown("Play"))
		{
			rb.bodyType = RigidbodyType2D.Dynamic;
		}
	}

}
