using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	Ray ray;
	RaycastHit hit;
	GameObject gameObject; 
	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) {
			ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if(Physics.Raycast(ray,out hit,60.0f)){
				if(hit.collider.name == "ElevatorButton"){
					
				}
			}
		}
	}
}
