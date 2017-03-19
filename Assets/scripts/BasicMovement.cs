using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour {

	private float speed;
	private float width;
	private float height;
	[SerializeField] private GameObject otherObject;
	private Structure myStructure;

	// Use this for initialization
	void Start () {
		speed = 3.0f;
		width = transform.localScale.x;
		height = transform.localScale.y;
		myStructure = otherObject.GetComponent<Structure>();
	}
	
	// Update is called once per frame
	void Update () {
		
		Move ();
	}

	void Move()
	{
		if (Input.GetKey("w") == true) 
		{
			if (CheckCollisionsStrict(myStructure) == false) 
			{
				print ("Yay!");
				transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
			} 
			if (CheckCollisionsLoose(myStructure)) 
			{
				transform.position = new Vector2 (transform.position.x, transform.position.y - 0.05f);
			}
		}
		if (Input.GetKey("a") == true) 
		{
			if (CheckCollisionsStrict(myStructure) == false) 
			{
				transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
			} 
			if (CheckCollisionsLoose(myStructure)) 
			{
				transform.position = new Vector2 (transform.position.x + 0.05f, transform.position.y);
			}
		}
		if (Input.GetKey("s") == true) 
		{
			if (CheckCollisionsStrict(myStructure) == false) 
			{
				transform.position = new Vector2(transform.position.x, transform.position.y - speed*Time.deltaTime);
			} 
			if (CheckCollisionsLoose(myStructure)) 
			{
				transform.position = new Vector2 (transform.position.x, transform.position.y + 0.05f);
			}
		}
		if (Input.GetKey("d") == true) 
		{
			if (CheckCollisionsStrict(myStructure) == false) 
			{
				transform.position = new Vector2(transform.position.x + speed*Time.deltaTime, transform.position.y);
			} 
			if (CheckCollisionsLoose(myStructure)) 
			{
				transform.position = new Vector2 (transform.position.x - 0.05f, transform.position.y);
			}
		}
	}

	bool CheckCollisionsLoose(Structure otherObject)
	{
		if (transform.position.x - width/2.0f - 0.05f < myStructure.GetX() + myStructure.GetWidth()/2.0f
			&& transform.position.x + width/2.0f + 0.05f > myStructure.GetX() - myStructure.GetWidth()/2.0f
			&& transform.position.y - height/2.0f - 0.05f < myStructure.GetY() + myStructure.GetHeight()/2.0f
			&& transform.position.y + height/2.0f + 0.05f > myStructure.GetY() - myStructure.GetHeight()/2.0f) 
		{
			return true;
		} 
		else 
		{
			return false;
		}
	}

	bool CheckCollisionsStrict(Structure otherObject)
	{
		if (transform.position.x - width/2.0f < myStructure.GetX() + myStructure.GetWidth()/2.0f
			&& transform.position.x + width/2.0f > myStructure.GetX() - myStructure.GetWidth()/2.0f
			&& transform.position.y - height/2.0f < myStructure.GetY() + myStructure.GetHeight()/2.0f
			&& transform.position.y + height/2.0f > myStructure.GetY() - myStructure.GetHeight()/2.0f) 
		{
			return true;
		} 
		else 
		{
			return false;
		}
	}

	void PushPlayer()
	{

	}
}
