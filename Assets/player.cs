using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int value = 1;
    public int type = 1;
    UI_Handler ui;

    public void changeType(int change) {
        if (change == 0) {
            type = 0;
        }
        else if (change == 1) {
            type = 1;
        }
        else if (change == 2) {
            type = 2;
        }
        changeValue();
    }

    public void changeValue() {
        if (type == 0) {
            value = 1;
        }
        else if (type == 1) {
            value = 10;
        }
        else if (type == 2) {
            value = 20;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
