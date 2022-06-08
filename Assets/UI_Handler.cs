using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Handler : MonoBehaviour {
    public GameObject[] Checkbox;
    public GameObject[] TrueFalse;
    public GameObject[] TextBox;
    public GameObject[] Dropdown;
    public Canvas UI;

    // Start is called before the first frame update
    void Awake() {
        Checkbox = new GameObject[15];
        TrueFalse = new GameObject[5];
        TextBox = new GameObject[5];
        Dropdown = new GameObject[5];
        /*
        for (int i = 0; i < 5; i++) {
            Checkbox[i] = new GameObject();
            TrueFalse[i] = new GameObject();
            TextBox[i] = new GameObject();
            Dropdown[i] = new GameObject();
        }
        */
        //UI = GetComponent<Canvas>();

        Checkbox[0] = GameObject.Find("Checkbox");
        TrueFalse[0] = GameObject.Find("TrueFalse");
        TextBox[0] = GameObject.Find("Textbox");
        Dropdown[0] = GameObject.Find("Dropdown");

        Checkbox[1] = GameObject.Find("Checkbox/Fields/InformationField/Text-Question (TMP)");
        TrueFalse[1] = GameObject.Find("TrueFalse/Fields/InformationField/Text-Question (TMP)");
        TextBox[1] = GameObject.Find("Textbox/Fields/InformationField/Text-Question (TMP)");
        Dropdown[1] = GameObject.Find("Dropdown/Fields/InformationField/Text-Question (TMP)");

        Checkbox[2] = GameObject.Find("Checkbox/Fields/InformationField/Text-Ex (TMP)");
        TrueFalse[2] = GameObject.Find("TrueFalse/Fields/InformationField/Text-Ex (TMP)");
        TextBox[2] = GameObject.Find("Textbox/Fields/InformationField/Text-Ex (TMP)");
        Dropdown[2] = GameObject.Find("Dropdown/Fields/InformationField/Text-Ex (TMP)");

        Checkbox[3] = GameObject.Find("Checkbox/Fields/Btn_Submit");
        TrueFalse[3] = GameObject.Find("TrueFalse/Fields/Btn_Submit");
        TextBox[3] = GameObject.Find("Textbox/Fields/Btn_Submit");
        Dropdown[3] = GameObject.Find("Dropdown/Fields/Btn_Submit");

        Checkbox[4] = GameObject.Find("Checkbox/Fields/GameObject/Answer A/Label");
        Checkbox[5] = GameObject.Find("Checkbox/Fields/GameObject/Answer A (1)/Label");
        Checkbox[6] = GameObject.Find("Checkbox/Fields/GameObject/Answer A (2)/Label");
        Checkbox[7] = GameObject.Find("Checkbox/Fields/GameObject/Answer A (3)/Label");

        Checkbox[8] = GameObject.Find("Checkbox/Fields/GameObject/Answer A");
        Checkbox[9] = GameObject.Find("Checkbox/Fields/GameObject/Answer A (1)");
        Checkbox[10] = GameObject.Find("Checkbox/Fields/GameObject/Answer A (2)");
        Checkbox[11] = GameObject.Find("Checkbox/Fields/GameObject/Answer A (3)");
        /*
        Checkbox[0].SetActive(false);
        TrueFalse[0].SetActive(false);
        TextBox[0].SetActive(false);
        Dropdown[0].SetActive(false);*/
        //UI.enabled = false;
    }

    public static GameObject[] checkbox() {
        UI_Handler ui = new UI_Handler();
        return ui.Checkbox;
    }

    public static GameObject[] truefalse() {
        UI_Handler ui = new UI_Handler();
        return ui.TrueFalse;
    }

    public static GameObject[] dropdown() {
        UI_Handler ui = new UI_Handler();
        return ui.Dropdown;
    }

    public static GameObject[] textbox() {
        UI_Handler ui = new UI_Handler();
        return ui.TextBox;
    }

    // Update is called once per frame
    void Update() {

    }
}
