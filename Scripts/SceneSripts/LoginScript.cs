using UnityEngine;

public class LoginScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //Starts welcoming player
        createSharedObject();
    }

    //If share object doesnt exist, creates it
    public static SharedData createSharedObject() {
        try
        {
            return GameObject.Find("SharedData").GetComponent<SharedData>();
        }
        catch
        {
            GameObject gameObject = Instantiate(Variables.sharedData);
            gameObject.name = "SharedData";
            return gameObject.GetComponent<SharedData>();
        }
    }
}
