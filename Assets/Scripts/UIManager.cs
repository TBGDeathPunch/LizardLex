﻿using UnityEngine;
using System.Collections;

public class UIManager : MonoBehaviour {

	public GUISkin MyGUISkin;
	public Texture2D Background;
	public Texture2D Logo;

	private Rect WindowRect = new Rect((Screen.width / 2) - 100, Screen.height / 2, 200, 200);

	private string menuState;

	public string[] CreditsTextLines = new string[0];

	private string main = "main";
	private string options = "options";
	private string credits = "credits";

	private string textToDisplay = "Credits \n";
	private float volume = 1.0f;

	// Use this for initialization
	void Start () 
	{
		menuState = main;

		for (int x = 0; x < CreditsTextLines.Length; x++)
		{
			textToDisplay += CreditsTextLines[x] + " \n ";
		}
		textToDisplay += "Press Esc To Go Back";
	}
	// UI setup
	private void OnGUI()
	{
		if (Background != null)
		{
			GUI.DrawTexture(new Rect(0,0, Screen.width, Screen.height), Background);
		}

		if (Logo != null)
		{
			GUI.DrawTexture(new Rect((Screen.width / 2) - 100, 30, 200, 200), Logo);
		}

		GUI.skin = MyGUISkin;

		// Check UI State
		if (menuState == main)
		{
			WindowRect = GUI.Window(0, WindowRect, menuFunc, "Main Menu");
		}

		if (menuState == options)
		{
			WindowRect = GUI.Window(1, WindowRect, optionsFunc, "Options");
		}

		if (menuState == credits)
		{
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height), textToDisplay);
		}
	}

	private void menuFunc (int id)
	{
		// buttons
		if (GUILayout.Button("Play Game"))
		{
			Application.LoadLevel("AllLevelsInOne");
		}

		if (GUILayout.Button("Options"))
		{
			menuState = options;
		}

		if (GUILayout.Button("Credits"))
		{
			menuState = credits;
		}

		if (GUILayout.Button("Quit Game"))
		{
			Application.Quit();
		}
	}

	private void optionsFunc (int id)
	{
		GUILayout.Box("Volume");
		volume = GUILayout.HorizontalSlider(volume, 0.0f, 1.0f);
		AudioListener.volume = volume;

		if (GUILayout.Button("Back To Main Menu"))
		{
			menuState = main;
		}
	}


	// Update is called once per frame
	void Update () 
	{
		if (menuState == credits && Input.GetKey(KeyCode.Escape))
		{
			menuState = main;
		}
	}
}
