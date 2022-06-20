using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
	private Timer timer;

	public GameObject player;

	public GameObject canvasObject;
	public GameObject contador;

	void Start()
	{
		timer = gameObject.GetComponent<Timer>();
		startGame();

	}

	public void startGame()
	{
		timer.startTimer();
	}

	public void endGame()
	{
		timer.stopTimer();
		Destroy(player);
		canvasObject.SetActive(true);
		contador.SetActive(false);
	}
}
