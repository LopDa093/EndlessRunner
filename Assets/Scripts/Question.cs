using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{

    public string title;
    public string text;
    public string answer;
    public string[] options;
    public int index = 0;
    public UI_Handler gameUI;

    public Question() {
        
    }

    public static Question CreateComponent(GameObject where) {
        Question myC = where.AddComponent<Question>();
        return myC;
    }

    public Question(string Title, string Text, string[] Answer, int ans) {
        title = Title;
        text = Text;
        for (int i = 0; i < Answer.Length; i++) {
            //answer[i] = Answer[i];
        }
        index = ans;
    }

    public void ChangeUI() {
        GameObject.Find("Checkbox").SetActive(true);
    }

    string getTitle() {
        return title;
    }

    string getQuestion() {
        return text;
    }

    public bool submit() {
        return false;
    }
}
