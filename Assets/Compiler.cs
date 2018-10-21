using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compiler : MonoBehaviour {
    public InputField inp;
    public Text inputFieldText;
    public string playersProgram;
    public string testText;
    private string[] codeLines;
   
    void Start() {
        inp.onEndEdit.AddListener(delegate { LockInput(inp); });
        //inp.onValueChange.AddListener(delegate { ValueChanged(); });

      
    }

    void LockInput(InputField input)
    {
        if (input.text.Length > 0)
        {
            Debug.Log("Text has been entered");
            playersProgram = inputFieldText.text;
            codeLines = playersProgram.Split('\n');
            testText = codeLines[codeLines.Length -1];
            List<List<string>> compiledProgram = new List<List<string>>();

            foreach (string word in codeLines)
            {
                string[] function = word.Split(' ');
                if (function[0] == "mov" && (function.Length == 3 || function.Length == 5) ) // mov a b      mov a b + c
                {
                    List<string> fff = new List<string>(function); 
                    compiledProgram.Add(fff);

                }else if(function[0] == "add" && function.Length == 3)
                {
                    List<string> fff = new List<string>(function);
                    compiledProgram.Add(fff);
                }
                else if (function[0] == "jump" && function.Length == 2)
                {
                    List<string> fff = new List<string>(function);
                    compiledProgram.Add(fff);
                }
                else if (function[0] == "if" && function.Length == 3)
                {
                    List<string> fff = new List<string>(function);
                    compiledProgram.Add(fff);
                }
            }
        }
        else if (input.text.Length == 0)
        {
            Debug.Log("Main Input Empty");
        }
    }
    /*
    void ValueChanged()  {
        Debug.Log("Value Changed");
      
    }*/
    
    void runProgram()
    {
        
    }

   
    void Update () {
        
    }
}
