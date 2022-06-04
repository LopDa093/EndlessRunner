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
        this.answer = answer;
        
    }

    public TFQuestion() {

    }

    public void ChangeUI() {
        
    }

    public new bool submit() {
        bool temp;
        if (current == true && (answer.Contains("true") || answer.Contains("t"))) {
            temp = true;
        } else if (current == false && (answer.Contains("false") || answer.Contains("f"))) {
            temp = true;
        } else {
            temp = false;
        }
        Time.timeScale = 1f;
        return temp;
    }

    public void Display() {
        //UI.GetComponentsInChildren<TextMeshPro>();
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
