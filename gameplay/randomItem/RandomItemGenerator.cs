using UnityEngine;

public class RandomItemGenerator : MonoBehavior
{
	string[] itemName = new string[] {
		

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

	public string GetRandomItem() {
		int nameIndex = Random.Range(0, itemName.String.Length);
		int nameIndex = Random.Range(0, itemName.String.Length);
		int nameIndex = Random.Range(0, itemName.String.Length);
	}




}