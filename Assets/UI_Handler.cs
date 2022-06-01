using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Handler : MonoBehaviour
{
    public GameObject Checkbox;
    public GameObject TrueFalse;
    public GameObject TextBox;
    public GameObject Dropdown;
    public Canvas UI;

    // Start is called before the first frame update
    void Start()
    {
        Checkbox = GameObject.Find("Checkbox");
        TrueFalse = GameObject.Find("TrueFalse");
        TextBox = GameObject.Find("Textbox");
        Dropdown = GameObject.Find("Dropdown");


        UI.enabled = false;
        Checkbox.SetActive(false);
        TrueFalse.SetActive(false);
        TextBox.SetActive(false);
        Dropdown.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
