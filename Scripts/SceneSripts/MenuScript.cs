using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
    public Text welcome;
    private SharedData sharedData;
    public GameObject sharedDataObject;

	void Start () {
        //Starts welcoming player
        sharedData = LoginScript.createSharedObject();
        welcome.text = welcome.text + " " + sharedData.username;
	}

    public void logout()
    {
        sharedData.username = SharedData.DEFAULT_NAME;
        SceneManager.LoadScene("Login");
    }
}
