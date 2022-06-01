using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TFQuestion : Question
{
    public bool current;

    public TFQuestion(string title, string question, string answer) {
        this.title = title;
        text = question;
        this.answer[0] = answer;
        UI = GameObject.Find("TrueFalse");
    }

    public TFQuestion() {

    }

    public bool submit() {
        bool temp;
        if (current == true && (answer[0].Contains("true") || answer[0].Contains("t"))) {
            temp = true;
        } else if (current == false && (answer[0].Contains("false") || answer[0].Contains("f"))) {
            temp = true;
        } else {
            temp = false;
        }
        return temp;
    }

    public void Display() {
        UI.GetComponentsInChildren<TextMeshPro>().;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
