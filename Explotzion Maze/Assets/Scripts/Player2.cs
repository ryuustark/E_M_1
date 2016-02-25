using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	public float speed = 50f;
	public float rotation = 150f;
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal2");
		float v = Input.GetAxis("Vertical2");

		transform.Translate(0f, 0f , v * speed * Time.deltaTime);
		transform.Rotate (0f, h * rotation * Time.deltaTime, 0f);


	}
		
}
