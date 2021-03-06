using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomItemGenerator : MonoBehavior
{
	string[] itemName = new string[] {
		"Dark Bushido the Fated",
		"Red Walrus",
		"Bloodhawk",
		"Doctor Nova",
		"Giant Naruto Uzumaki Ivy",
		"Red Clea Lord",
		"Jack of Hearts",
		"General Mandarin the Hunter",
		"Captain Monarch",
		"Ultra Cat",
		"Green Leader Lord",
		"Ultra Sylar Machine",
		"Ultra Proto-Goblin",
		"Doomsday I",
		"Ariel Dragon",
		"Hybrid Eyes",
		"Cyborg Walrus",
		"Cy-Gor XI",
		"Red Archangel",
		"Bloodaxe Fist",
		"Illustrious Firestorm Machine",
		"Mr Copycat XI",
		"Green Storm",
		"Agent Speedball",
		"Giant Silk Girl",
		"Captain Thing Machine",
		"Magnificent Shang-Chi Fist",
		"Captain Feral Boy",
		"Green Morph",
		"Supah Bird Lord",
		"Cat",
		"Warlock"
	};

	string[] itemDescription = new string[]{	
		"finished World of Warcraft",
		"knows the last digit of PI",
		"is immutable. If something's going to change, it's going to have to be the rest of the universe!",
		"doesn't need an OS",
		"can instantiate an abstract class",
		"rewrote the Google search engine from scratch",
		"doesn't have disk latency because the hard drive knows to hurry the hell up",
		"doesn't need to know about class factory pattern. He can instantiate interfaces",
		"can recite π. Backwards!",
		"can binary search unsorted data",
		"doesn't need a debugger, he just stares down the bug until the code confesses",
		"keyboard doesn't have a F1 key, the computer asks him for help"
	};

	string[] itemDimension = new string[] {
		"On a Cab Planet",
		"Dimension C-137",
		"Alphabetrium",
		"Gazorpazorp",
		"Purge Planet",
		"Bird World",
		"Cronenberg World"
	};

	string[] itemPower = new string[] {
		"Longevity",
		"Possession",
		"Natural Weapons",
		"Anti-Gravity",
		"Darkforce Manipulation",
		"Energy Resistance",
		"Telekinesis",
		"Summoning",
		"Psychokinesis",
		"Endurance",
		"Adaptation",
		"Intelligence",
		"Molecular Combustion",
		"Radar Sense",
		"Danger Sense",
		"Bullet Time",
		"Apotheosis",
		"Photokinesis"
	};

	public string GetRandomItem() {
		int nameIndex = Random.Range(0, itemName.String.Length);
		int descriptionIndex = Random.Range(0, itemDescription.String.Length);
		int dimensionIndex = Random.Range(0, itemDimension.String.Length);
		int powerIndex = Random.Range(0, itemPower.String.Length);

		string itemGenerated = 
			"Name: " + itemName[nameIndex] + " || " +
			"Power: " + itemPower[powerIndex] + " || " +
			"Dimension: " + itemDimension[dimensionIndex] +
			"Description: " + itemDescription[descriptionIndex];
			
		return itemGenerated;
	}

	void Start()
	{
		print(GetRandomItem());
	}




}