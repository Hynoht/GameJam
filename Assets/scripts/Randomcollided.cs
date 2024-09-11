using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collidedMove : MonoBehaviour
{
	private Vector3	startPosition;
	public	Transform	start;
	public float		speed = 6f;
	public List<GameObject>	collisionObject;
	public GameObject[]		objectPrefab;
	private float		time;
	private int			modulo = 3;

	void Start()
	{
		startPosition = new Vector3(start.position.x, 0.0f, 0.0f);
	}

	void Update()
	{
		for (int j = 0; j < collisionObject.Count; j++)
		{
			if (collisionObject[j] != null)
			{
				collisionObject[j].transform.Translate(Vector3.left * speed * Time.deltaTime);
				if (collisionObject[j].transform.position.x < -30f)
				{
					collisionObject.Remove(collisionObject[j]);
				}
			}
		}
		time += Time.deltaTime;
		if (time % modulo >= 2f)
		{
			AddNewObject();
			time = 0;
		}
	}
	void	AddNewObject()
	{
		int	random;

		random = Random.Range(0, 4);
		GameObject newObject = Instantiate(objectPrefab[random], startPosition, Quaternion.identity);
		collisionObject.Add(newObject);
	}
}
