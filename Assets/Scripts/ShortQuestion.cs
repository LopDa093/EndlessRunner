using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortQuestion : Question
{
    public string[] answers;
    public ShortQuestion() {

    }

    public ShortQuestion(string title, string question, string[] options) {
        this.title = title;
        text = question;
        for (int i = 0; i < options.Length; i++) {
            answers[i] = options[i];
        }
    }

    public static ShortQuestion CreateComponent(GameObject where, string parameter, string question, string[] answer) {
        ShortQuestion myC = where.AddComponent<ShortQuestion>();
        myC.title = parameter;
        myC.text = question;
        //myC.answer = answer;
        for (int i = 0; i < answer.Length; i++) {
            myC.answers[i] = answer[i];
        }
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
