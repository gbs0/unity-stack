using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehavior
{
	// Init String Array for card suits
	public static string[] naipes = new string[] { "C", "D", "H", "S" };
	// Init String Array for card values
	public static string[] values = new string[] { "A","1","2","3", "4", "5", "6", "7", "8","9","10", "K", "Q", "J" };

	void Start(){

	}

	void Update(){

	}

	public static List<string> GerarDeck()
	{
		List<string> deckNovo = new List<string>();
		
		foreach (string naipe in naipes) {
			foreach (string value in values) {
				deckNovo.Add(naipe + value);
			}
		}
	}

}