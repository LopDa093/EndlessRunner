using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropdown : Question
{
    public Dropdown() {
        
    }

    public static Dropdown CreateComponent(GameObject where, string parameter, string question, string answer, string name, string[] ans) {
        Dropdown myC = where.AddComponent<Dropdown>();
        myC.name = name;
        myC.title = parameter;
        myC.text = question;
        //myC.index = 2;

        for (int i = 2; i < ans.Length-2; i++) {
            myC.options[i] = ans[i+2];
        }
        /*myC.options[0] = ans[2];
        myC.options[1] = ans[3];
        myC.options[2] = ans[4];
        myC.options[3] = ans[5];*/
        for (int i = 0; i < myC.options.Length; i++) {
            if (myC.options[i] == answer) {
                myC.index = i;
            }
        }
        return myC;
    }
}
