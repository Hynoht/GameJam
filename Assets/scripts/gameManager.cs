using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public GameObject	gameOver;
	public GameObject	gameStart;
	public GameObject	player;
	public GameObject	score;
	public GameObject	playPanel;
	public GameObject	pausePanel;
	public Image		panelHome;
	public Image		panelPlay;
	public Image		panelGameOver;
	public bool			isMute = false;
	public bool			isPaused = false;
	public bool			start = false;
	public bool			openPanelPlay = false;
	static int 	i;
    void Start()
    {
		start = true;
        Time.timeScale = 0;
		if (i >= 1)
			isStart();
		i++;
    }

	public void	isGameOver()
	{
		openPanelPlay = true;
		gameOver.SetActive(true);
		pausePanel.SetActive(false);
		score.SetActive(false);
		start = false;
		Time.timeScale = 0;
	}

	public void isStart()
	{
		player.SetActive(true);
		score.SetActive(true);
		pausePanel.SetActive(true);
		gameStart.SetActive(false);
		Time.timeScale = 1;
		if (start == false)
		{
			start = true;
			reLoad();
		}
	}
	
	public void	reLoad()
	{
		SceneManager.LoadScene(1);
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

	public void Menu()
	{
		gameStart.SetActive(true);
		gameOver.SetActive(false);
	}

	public void Quit()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
