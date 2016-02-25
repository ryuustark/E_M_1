using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour 
{
	public float speed = 50f;
	public float rotation = 150f;
	// Update is called once per frame
	void Update ()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
	
		transform.Translate(0f, 0f , v * speed * Time.deltaTime);
		transform.Rotate (0f, h * rotation * Time.deltaTime, 0f);

	}
		
}
