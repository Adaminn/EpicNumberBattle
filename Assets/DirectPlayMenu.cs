using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DirectPlayMenu : MonoBehaviour {

	// Use this for initialization
	public void playDirectPlay () {
        SceneManager.LoadScene("hmmm");
	}
	
	// Update is called once per frame
	public void goToMainMenu () {
        SceneManager.LoadScene("Menu");
	}
}
