﻿using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	public delegate void metodoDelegado();
	public static metodoDelegado Evento;

	void OnCollisionEnter(Collision col){
		Evento ();
	}

}
