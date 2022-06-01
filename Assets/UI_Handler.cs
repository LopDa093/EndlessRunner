using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Handler : MonoBehaviour
{
    public Canvas Checkbox;
    public Canvas TrueFalse;
    public Canvas TextBox;
    public Canvas Dropdown;

    // Start is called before the first frame update
    void Start()
    {
        
        Checkbox.enabled = false;
        TrueFalse.enabled = false;
        TextBox.enabled = false;
        Dropdown.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
