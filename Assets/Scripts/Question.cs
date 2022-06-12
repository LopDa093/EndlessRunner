using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour {
    public string name;
    public string title;
    public string text;
    public string[] answer;
    public string[] options;
    public int index = 0;
    public UI_Handler gameUI;
    public int ansIndex = 0;
    public string correct = "";
    public bool executed = false;
    bool action = false;
    private GameObject checkboxs;

    private void Awake() {
        answer = new string[5];
        options = new string[5];
        gameUI = gameObject.AddComponent<UI_Handler>();
        checkboxs = GameObject.Find("Checkbox");
    }

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

    public IEnumerable WaitForAction() {
        action = false; // clear last action, we want a new one
        while (action == false) { yield return null; }
    }

    void TaskOnClick() {
        if (ansIndex == index) {
            correct = "correct";
            action = true;
            executed = true;
            checkboxs.SetActive(false);
            Time.timeScale = 1f;
        }
        else {
            correct = "false";
            action = true;
            executed = true;
            checkboxs.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    void CheckboxChanged1(Toggle t) {
        ansIndex = 0;
    }

    void CheckboxChanged2(Toggle t) {
        ansIndex = 1;
    }

    void CheckboxChanged3(Toggle t) {
        ansIndex = 2;
    }

    void CheckboxChanged4(Toggle t) {
        ansIndex = 3;
    }

    void TrueFalseChanged1(Toggle t) {
        ansIndex = 0;
    }

    void TrueFalseChanged2(Toggle t) {
        ansIndex = 1;
    }


    public string ChangeUI(string name, string title, string text, string[] temp) {
        Time.timeScale = 0f;
        if (name == "Checkbox") {
            checkboxs.SetActive(true);
            gameUI.Checkbox[1].GetComponent<TMPro.TextMeshProUGUI>().text = title;
            gameUI.Checkbox[2].GetComponent<TMPro.TextMeshProUGUI>().text = text;
            gameUI.Checkbox[4].GetComponent<TMPro.TextMeshProUGUI>().text = temp[0];
            gameUI.Checkbox[5].GetComponent<TMPro.TextMeshProUGUI>().text = temp[1];
            gameUI.Checkbox[6].GetComponent<TMPro.TextMeshProUGUI>().text = temp[2];
            gameUI.Checkbox[7].GetComponent<TMPro.TextMeshProUGUI>().text = temp[3];
            gameUI.Checkbox[3].GetComponent<Button>().onClick.AddListener(TaskOnClick);

            gameUI.Checkbox[8].GetComponent<Toggle>().onValueChanged.AddListener(delegate {
                CheckboxChanged1(gameUI.Checkbox[8].GetComponent<Toggle>());
            });

            gameUI.Checkbox[9].GetComponent<Toggle>().onValueChanged.AddListener(delegate {
                CheckboxChanged2(gameUI.Checkbox[9].GetComponent<Toggle>());
            });

            gameUI.Checkbox[10].GetComponent<Toggle>().onValueChanged.AddListener(delegate {
                CheckboxChanged3(gameUI.Checkbox[10].GetComponent<Toggle>());
            });

            gameUI.Checkbox[11].GetComponent<Toggle>().onValueChanged.AddListener(delegate {
                CheckboxChanged4(gameUI.Checkbox[11].GetComponent<Toggle>());
            });

                return correct;
            
            /*
            if (executed == true) {
                return correct;
            }
            else {
                ChangeUI(obj,name, title,text, temp);
            }*/


        } else if (name == "TrueFalse") {
            gameUI.TrueFalse[0].SetActive(true);
            gameUI.TrueFalse[1].GetComponent<TMPro.TextMeshProUGUI>().text = title;
            gameUI.TrueFalse[2].GetComponent<TMPro.TextMeshProUGUI>().text = text;
            gameUI.TrueFalse[3].GetComponent<Button>().onClick.AddListener(TaskOnClick);
            
            gameUI.TrueFalse[4].GetComponent<Toggle>().onValueChanged.AddListener(delegate {
                CheckboxChanged4(gameUI.Checkbox[11].GetComponent<Toggle>());
            });
            gameUI.TrueFalse[5].GetComponent<Toggle>().onValueChanged.AddListener(delegate {
                CheckboxChanged4(gameUI.Checkbox[11].GetComponent<Toggle>());
            });

            if (executed == true) {
                return correct;
            }
            else {
                //ChangeUI(obj, name, title, text, temp);
            }
            return "";
        }
        else {
            return "";
        }
        /*
        else if (name == "Dropdown") {
            gameUI.Dropdown[0].SetActive(true);
            gameUI.Dropdown[1].GetComponent<TMPro.TextMeshProUGUI>().text = title;
            gameUI.Dropdown[2].GetComponent<TMPro.TextMeshProUGUI>().text = text;
            gameUI.Dropdown[3].GetComponent<Button>().onClick.AddListener(TaskOnClick);
            /*if (executed == true) {
                return correct;
            }
            else {
                ChangeUI(obj, name, title, text, temp);
            }
        }
        else if (name == "TextBox") {
            gameUI.TextBox[0].SetActive(true);
            gameUI.TextBox[1].GetComponent<TMPro.TextMeshProUGUI>().text = title;
            gameUI.TextBox[2].GetComponent<TMPro.TextMeshProUGUI>().text = text;
            gameUI.TextBox[3].GetComponent<Button>().onClick.AddListener(TaskOnClick);
           /*if (executed == true) {
                return correct;
            }
            else {
                ChangeUI(obj, name, title, text, temp);
            }
        }
        else {
            /*if (executed == true) {
                return correct;
            }
            else {
                ChangeUI(obj, name, title, text, temp);
            }
        }*/
    }

    string getTitle() {
        return title;
    }

    string getQuestion() {
        return text;
    }

    public bool submit() {

        return true;
    }
}