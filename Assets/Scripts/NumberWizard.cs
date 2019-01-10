using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour {
		[SerializeField] int max;
		[SerializeField] int min;
		[SerializeField] TextMeshProUGUI guessText;

		int guess;
	// Use this for initialization
	void Start () {
		
		StartGame();
	}
	
	void StartGame()
	{
		max = max + 1;
		guess = (max + min) / 2;
		guessText.text = guess.ToString();
	}
	public void OnPressHigher()
	{
		max = guess;
		NextGuess();
	}

	public void OnPressLower()
	{
		max = guess;
		NextGuess();
	}
	
	void NextGuess()
		{
			guess = (max + min) / 2;
			guessText.text = guess.ToString();
		}
}
