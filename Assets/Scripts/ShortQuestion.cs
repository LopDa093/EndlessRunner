using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortQuestion : Question
{
    //public string[] answers;
    public ShortQuestion() {

    }

    public ShortQuestion(string title, string question, string[] options) {
        this.title = title;
        text = question;
        for (int i = 0; i < options.Length; i++) {
            answer[i] = options[i];
        }
    }

    public static ShortQuestion CreateComponent(GameObject where, string parameter, string question, string[] answers, string name) {
        ShortQuestion myC = where.AddComponent<ShortQuestion>();
        myC.name = name;
        myC.title = parameter;
        myC.text = question;
        //myC.answer[0] = "";
        //myC.answer = answer;
        myC.answer[0] = answers[0];
        myC.answer[1] = answers[1];
        myC.answer[2] = answers[2];
        return myC;
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
