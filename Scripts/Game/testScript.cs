using UnityEngine;
using UnityEngine.UI;

public class testScript : MonoBehaviour {
    
    public Text testVystup;
    Compiler playerScript;
    // Use this for initialization
    void Start () {
        GameObject programTest = GameObject.Find("ProgramIF");
        playerScript = programTest.GetComponent<Compiler>();
    }
	
	// Update is called once per frame
	void Update () {
        testVystup.text = playerScript.testText;
    }
}
