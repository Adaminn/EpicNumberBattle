using UnityEngine;
using UnityEngine.UI;

public class InputFieldListener : MonoBehaviour {
    public Values value;
    private SharedData sharedData;

    // Gets input field and change value of shared object
    public void changeValue () {
        sharedData = GameObject.Find(Variables.sharedDataObjectName).GetComponent<SharedData>();
        InputField input = this.GetComponent<InputField>();
        if (input.text != "") {
            switch (value)
            {
                case Values.Username:
                    sharedData.username = input.text;
                    break;
            }
        }
    }
}

[System.Serializable]
public enum Values
{
    Username = 0
}
