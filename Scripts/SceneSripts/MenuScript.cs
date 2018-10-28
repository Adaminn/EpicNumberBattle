using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
    public Text welcome;
    private SharedData sharedData;
    private TCPClient client;
    public GameObject sharedDataObject;
    public Button connectButton;
    public Text connectionStatusText;

    void Start()
    {
        //Starts welcoming player
        sharedData = LoginScript.checkSharedObject();
        welcome.text = welcome.text + " " + sharedData.username;
        client = checkConnectionObject();
        connectButton.onClick.AddListener(connect);
    }

    public void logout()
    {
        sharedData.username = SharedData.DEFAULT_NAME;
        SceneManager.LoadScene("Login");
    }

    public void connect()
    {
        connectionStatusText.text = client.startClient();
    }

    public static TCPClient checkConnectionObject()
    {
        try
        {
            return GameObject.Find(Variables.connectionObjectName).GetComponent<TCPClient>();
        }
        catch
        {
            GameObject gameObject = Instantiate(Variables.connectionObject);
            gameObject.name = Variables.connectionObjectName;
            return gameObject.GetComponent<TCPClient>();
        }
    }
}
