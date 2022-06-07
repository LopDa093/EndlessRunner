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

    public static MultiQuestion CreateComponent(GameObject where, string parameter, string question, string answer, string name, string[] ans) {
        MultiQuestion myC = where.AddComponent<MultiQuestion>();
        myC.name = name;
        myC.title = parameter;
        myC.text = question;
        //myC.index = 2;
        myC.options[0] = ans[2];
        myC.options[1] = ans[3];
        myC.options[2] = ans[4];
        myC.options[3] = ans[5];
        for (int i = 0; i < myC.options.Length; i++) {
            if (myC.options[i] == answer) {
                myC.index = i;
            }
        }
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
