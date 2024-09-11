using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionController : MonoBehaviour
{
	public GameManager	game;
	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.name == "collision")
			game.isGameOver();
	}
	private void OnTriggerEnter2D(Collider2D other)
	{
		score.scoreValue++;
	}
}
