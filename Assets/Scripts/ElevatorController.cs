using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorController : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void moveDown ()
	{
		iTween.MoveBy (gameObject, iTween.Hash ("y", -2, "easeType", "easeInOutExpo", "loopType", "none", "delay", 2,"speed", 6));
	}

	public void moveUp ()
	{
		iTween.MoveBy (gameObject, iTween.Hash ("y", -2, "easeType", "easeInOutExpo", "loopType", "none", "delay", 2,"speed", 6));
	}



}
