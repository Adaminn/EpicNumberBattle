using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwap : MonoBehaviour {

	// Use this for initialization
	public void swapScene (string loadScene) {
        SceneManager.LoadScene(loadScene);
	}

    public void startGame() {
        SceneManager.LoadScene("Game");
    }

    public void startGame(int IPAdress)
    {
        SceneManager.LoadScene("Game");
    }
}
