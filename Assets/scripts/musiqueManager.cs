using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musiqueManager : MonoBehaviour
{
	[SerializeField] AudioSource	musicSource;
	public AudioClip				background;

	void Start()
	{
		musicSource.clip = background;
		musicSource.Play();
		Debug.Log("PLAY");
	}

	/*public void PlayMusic()
	{
		if (audioSource != null && !audioSource.isPlaying)
		{
			audioSource.Play();
		}
	}
	public void StopMusic()
	{
		if (audioSource != null && audioSource.isPlaying)
		{
			audioSource.Stop();
		}
	}
	public void SetVolume(float volume)
	{
		if (audioSource != null)
		{
			audioSource.volume = volume;
		}
	}*/
}
