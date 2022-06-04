using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Handler : MonoBehaviour
{
    public GameObject[] Checkbox;
    public GameObject[] TrueFalse;
    public GameObject[] TextBox;
    public GameObject[] Dropdown;
    public Canvas UI;

    // Start is called before the first frame update
    void Start()
    {
        /*
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
        
        
        UI.enabled = false;
        Checkbox[0].SetActive(false);
        TrueFalse[0].SetActive(false);
        TextBox[0].SetActive(false);
        Dropdown[0].SetActive(false);
        */
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
    void Update()
    {
        
    }
}
