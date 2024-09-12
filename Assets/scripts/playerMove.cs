using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
	private float		jump = 500;
	public bool			isJumping = false;
	private bool		isDead = true;

	public Rigidbody2D	rb;
	public GameManager	game;
	AudioManager	audioManager;
	private void Awake()
	{
		audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
	}
    void Update()
    {
		if (transform.position.y >= 15 && isDead == true)
		{
			audioManager.PlaySFX(audioManager.hit);
			game.isGameOver();
			audioManager.PlaySFX(audioManager.die);
			isDead = false;
		}
        if (Input.GetButtonDown("Jump") && game.isPaused == false)
		{
			audioManager.PlaySFX(audioManager.wing);
			isJumping = true;
			rb.AddForce(new Vector2(0f, jump));
			isJumping = false;
		}
    }
}
