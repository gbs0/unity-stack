using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
 		// Add method for load Scene '1', previously on scene build menu   
    public void PlayGame()
    {
    	// SceneManager class
    	SceneManager.LoadScene(1);

    	// On Button Menu Element
    	// add the current class
    	// as on click function
    	// for call PlayGame();
    }
}
