using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiQuestion : Question
{
    public Canvas UI;


    public MultiQuestion(string title, string question, string answer) {
        this.title = title;
        text = question;
        this.answer = answer;
    }

    public static MultiQuestion CreateComponent(GameObject where, string parameter, string question, string answer) {
        MultiQuestion myC = where.AddComponent<MultiQuestion>();
        myC.title = parameter;
        myC.text = question;
        myC.answer = answer;
        return myC;
    }

    public void ChangeUI() {

    }

    public MultiQuestion() {

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
