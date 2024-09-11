using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
	private float		jump = 300;
	public bool			isJumping = false;
	public Rigidbody2D	rb;
	public GameManager	game;
    void Start()
    {
        
    }
    void Update()
    {
		if (transform.position.y > 10)
			game.isGameOver();
        if (Input.GetButtonDown("Jump") && game.isPaused == false)
		{
			isJumping = true;
			rb.AddForce(new Vector2(0f, jump));
			isJumping = false;
		}
    }
}
