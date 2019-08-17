using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehavior
{
	// Init String Array for card suits
	public static string[] naipes = new string[] { "C", "D", "H", "S" };
	// Init String Array for card values
	public static string[] values = new string[] { "A","1","2","3", "4", "5", "6", "7", "8","9","10", "K", "Q", "J" };

	void Start()
	{
		// PlayCards();
	}

	void Update()
	{

	}

	public void PlayCards()
	{
		deck = GerarDeck();
		Embaralhar(deck);

		foreach (string card in deck)
		{
			print(card); // test some cards, but deck isn't shuffle yet
		}	
	}

	// Method for init a new Deck with naipe and value
	public static List<string> GerarDeck()
	{
		List<string> deckNovo = new List<string>();
		
		foreach (string naipe in naipes) {
			foreach (string value in values) {
				deckNovo.Add(naipe + value);
			}
		}
		return deckNovo;
	}

	void Embaralhar<T>(List<T> list)
	{
		System.Random random = new System.Random();
		int number = list.Count;
		while (number > 1)
		{
			int index = random.Next(number);
			number--;
			T cache = list[index];
			list[index] = list[number];
			list[number] = cache;
		}
	}

}