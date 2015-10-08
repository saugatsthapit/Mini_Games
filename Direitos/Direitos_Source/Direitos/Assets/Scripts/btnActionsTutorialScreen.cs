﻿using UnityEngine;
using System.Collections;
using Tamboro;

public class btnActionsTutorialScreen : MonoBehaviour {

	public GameManager Game;

	public AudioClip tutorial1;
	public AudioClip tutorial2;
	public AudioClip tutorial3;
	public AudioClip tutorial4;

	public UILabel lblTutorial1;
	public UILabel lblTutorial2;
	public UILabel lblTutorial3;
	public UILabel lblTutorial4;

	void OnEnable()
	{
		lblTutorial1.text = Strings.Instance.getStringByName("tutorial1");
		lblTutorial2.text = Strings.Instance.getStringByName("tutorial2");
		lblTutorial3.text = Strings.Instance.getStringByName("tutorial3");
		lblTutorial4.text = Strings.Instance.getStringByName("tutorial4");

//		SoundManager.Instance.Play(tutorial1);
//		Invoke("playTutorial2",8f);
//		Invoke("playTutorial3",13f);
	}

	void playTutorial2()
	{
		SoundManager.Instance.Pause();
		SoundManager.Instance.Play(tutorial2);
	}

	void playTutorial3()
	{
		SoundManager.Instance.Pause();
		SoundManager.Instance.Play(tutorial3);
	}

	public void btnCloseClicked()
	{
		SoundManager.Instance.Pause();
		Game.playButtonSound();
		this.gameObject.SetActive(false);
	}
	
	public void btnTutorial1Clicked()
	{
		SoundManager.Instance.Pause();
		Game.playButtonSound();
		SoundManager.Instance.Play(tutorial1);
	}
	
	public void btnTutorial2Clicked()
	{
		SoundManager.Instance.Pause();
		Game.playButtonSound();
		SoundManager.Instance.Play(tutorial2);
	}
	
	public void btnTutorial3Clicked()
	{
		SoundManager.Instance.Pause();
		Game.playButtonSound();
		SoundManager.Instance.Play(tutorial3);
	}

	public void btnTutorial4Clicked()
	{
		SoundManager.Instance.Pause();
		Game.playButtonSound();
		SoundManager.Instance.Play(tutorial4);
	}
}