using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGloops : MonoBehaviour
{
	public float	speed = 6f;
	private Vector3	startPosition;
	void Start()
	{
		startPosition = transform.position;
	}

	void Update()
	{
		transform.Translate(Vector3.left * speed * Time.deltaTime);
		if (transform.position.x < -32.012f)
			transform.position = startPosition;
	}
}
