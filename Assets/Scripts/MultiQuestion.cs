using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiQuestion : Question
{
    public Canvas UI;


    public MultiQuestion(string title, string question, string answer) {
        this.title = title;
        text = question;
        this.answer[0] = answer;
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
