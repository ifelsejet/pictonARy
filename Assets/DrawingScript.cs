using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DrawingScript : MonoBehaviour
{
    public void GoToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}

    public void handleSubmit()
	{
        // ... 
	}
    
}
