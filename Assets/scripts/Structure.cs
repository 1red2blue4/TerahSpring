using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Structure : MonoBehaviour {

	private float width;
	private float height;
	private float myX;
	private float myY;

	public float GetWidth()
	{
		return width;
	}

	public float GetHeight()
	{
		return height;
	}

	public float GetX()
	{
		return myX;
	}

	public float GetY()
	{
		return myY;
	}

	// Use this for initialization
	void Start () {
		width = transform.localScale.x;
		height = transform.localScale.y;
		myX = transform.position.x;
		myY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
