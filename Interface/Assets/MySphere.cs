using UnityEngine;
using System.Collections;
using System;

public class MySphere : MonoBehaviour, IGvrGazeResponder{
   
	public void OnGazeEnter(){
		transform.position += new Vector3 (0f, 1f, 0f);
	}

	public void OnGazeExit(){}

	public void OnGazeTrigger(){}

    void Start () {
	
	}

	void Update () {
	
	}
}
