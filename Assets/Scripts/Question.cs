using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{

    public string title;
    public string text;
    public string[] answer;
    public int index = 0;
    public GameObject UI;

    public Question() {

    }

    public Question(string Title, string Text, string[] Answer, int ans) {
        title = Title;
        text = Text;
        for (int i = 0; i < Answer.Length; i++) {
            answer[i] = Answer[i];
        }
        index = ans;
    }

    string getTitle() {
        return title;
    }

    string getQuestion() {
        return text;
    }



    /*
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    */
}
