using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	[SerializeField] AudioSource	musicSource;
	public AudioClip				die;
	public AudioClip				hit;
	public AudioClip				point;
	public AudioClip				wing;

	void Start()
	{
		/*musicSource.clip = background;
		musicSource.Play();
		Debug.Log("PLAY");*/
	}

	public void PlaySFX(AudioClip clip)
	{
		musicSource.PlayOneShot(clip);
	}
}
