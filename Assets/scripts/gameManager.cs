using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject	gameOver;
	public GameObject	gameStart;
	public GameObject	player;
	public GameObject	score;
	public GameObject	playPanel;
	public GameObject	pausePanel;
	public GameObject	world1;
	public GameObject	world2;
	public bool			isMute = false;
	public bool			isPaused = false;
	public bool			start = false;
	public bool			openPanelPlay = false;
	static int 	i;
    void Start()
    {
		/*sound = GetComponent<AudioSource>();
		if (!sound.isPlaying)
		{
			sound.Play();
		}*/
		world2.SetActive(false);
        Time.timeScale = 0;
		if (i >= 1)
			isStart();
		i++;
    }

	public void	isGameOver()
	{
		openPanelPlay = true;
		gameOver.SetActive(true);
		Time.timeScale = 0;
		start = false;
		pausePanel.SetActive(false);
	}

	public void isStart()
	{
		player.SetActive(true);
		score.SetActive(true);
		pausePanel.SetActive(true);
		gameStart.SetActive(false);
		Time.timeScale = 1;
		start = true;
	}
	
	public void	reLoad()
	{
		SceneManager.LoadScene(0);
	}

	public void pause()
	{
		Time.timeScale = 0;
		playPanel.SetActive(true);
		pausePanel.SetActive(false);
	}

	public void play()
	{
		Time.timeScale = 1;
		pausePanel.SetActive(true);
		playPanel.SetActive(false);
	}

	public void isWorld1()
	{
		world2.SetActive(false);
		world1.SetActive(true);
	}

	public void isWorld2()
	{
		world1.SetActive(false);
		world2.SetActive(true);
	}

	public void Sounds()
	{
	}
}
