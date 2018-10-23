using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour {

	//Change scene to given string
	public void swapScene (string scene)
    {
        SceneManager.LoadScene(scene);
	}

    //Always change scene to game, without setting IPAdress
    public void startGame()
    {
        SceneManager.LoadScene("Game");
    }

    //For fututure content
    public void startGame(int IPAdress)
    {
        SceneManager.LoadScene("Game");
    }
    
    //Exist game
    public void exitGame()
    {
        Application.Quit();
    }
}
