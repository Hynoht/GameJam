using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{
	AudioManager	audioManager;
	public GameManager	game;
	private void Awake()
	{
		audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
	}
	private void OnCollisionEnter2D(Collision2D collision)
	{
		audioManager.PlaySFX(audioManager.hit);
		game.isGameOver();
		audioManager.PlaySFX(audioManager.die);
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		audioManager.PlaySFX(audioManager.point);
		score.scoreValue++;
	}
}
