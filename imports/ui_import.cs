using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIScript : MonoBehaviour
{
		//Init GameObject
		public Text lifes;

    public void DoSomething(int value)
    {
    	lifes.text = "Lifes: " + value;
    }
}
