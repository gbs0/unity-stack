using UnityEngine;

public class RandomItemGenerator : MonoBehavior
{
	string[] itemName = new string[] {

	};

	string[] itemDescription = new string[]{	

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