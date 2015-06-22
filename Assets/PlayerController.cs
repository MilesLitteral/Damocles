using UnityEngine;
using System.Collections;

public class Dbound 
{
	public float xMin, xMax, yMin, yMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour {

	public float speed;
	public Rigidbody rb;
	public Dbound Boundary;
	public float tilt;

	//private float nextFire;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.velocity = movement * speed;

	}

	void onCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Enemy") 
		{
			Destroy(this.gameObject);
		}
	}
}
