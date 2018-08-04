using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour {

    public float speed;

	private Vector3 vector;

	public float runSpeed;
	private float applyRunSpeed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

		if(Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
		{
			if (Input.GetKey(KeyCode.LeftShift))
			{
				applyRunSpeed = runSpeed;
			}
			else 
				applyRunSpeed = 0;

			vector.Set (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"), transform.position.z);

			if (vector.x != 0) 
			{
				transform.Translate (vector.x * (speed + applyRunSpeed) , 0, 0);

			}
			else if(vector.y != 0)
			{
				transform.Translate (0, vector.y * (speed + applyRunSpeed) , 0);
			}
				

		}
	}
}
