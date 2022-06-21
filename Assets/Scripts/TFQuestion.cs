using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TFQuestion : Question {
    public bool current;

    public TFQuestion(string title, string question, string answer) {
        this.title = title;
        text = question;
        this.answer[0] = answer;

    }

    public static TFQuestion CreateComponent(GameObject where, string parameter, string question, string answer, string name) {
        TFQuestion myC = where.AddComponent<TFQuestion>();
        myC.name = name;
        myC.title = parameter;
        myC.text = question;
        if (answer.Contains("F")) {
            myC.answer[0] = ""+1;
        }
        else {
            myC.answer[0] = ""+0;
        }
        return myC;
    }

    public TFQuestion() {

    }

    public void ChangeUI() {

    }

    public new bool submit() {
        bool temp;
        if (current == true && (answer[0].Contains("true") || answer[0].Contains("t"))) {
            temp = true;
        }
        else if (current == false && (answer[0].Contains("false") || answer[0].Contains("f"))) {
            temp = true;
        }
        else {
            temp = false;
        }
        Time.timeScale = 1f;
        return temp;
    }

    public void Display() {
        //UI.GetComponentsInChildren<TextMeshPro>();
    }

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
}
