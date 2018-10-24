using UnityEngine;

public class LoginScript : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //Starts welcoming player
        checkSharedObject();
    }

    //If share object doesnt exist, creates it
    public static SharedData checkSharedObject() {
        try
        {
            return GameObject.Find(Variables.sharedDataObjectName).GetComponent<SharedData>();
        }
        catch
        {
            GameObject gameObject = Instantiate(Variables.sharedDataObject);
            gameObject.name = Variables.sharedDataObjectName;
            return gameObject.GetComponent<SharedData>();
        }
    }
}
