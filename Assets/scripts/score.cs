using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
	public Text scoreTxt;
	public static float	scoreValue;
    void Start()
    {
        scoreValue = 0;
		scoreTxt.text = scoreValue.ToString();
    }

    void Update()
	{
		scoreTxt.text = scoreValue.ToString();
	}
}
