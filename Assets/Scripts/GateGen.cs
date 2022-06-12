using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateGen : MonoBehaviour
{
    public GameObject[] gates;

    // Start is called before the first frame update
    void Start()
    {
        decide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void decide() {
        int x = Random.Range(1, 2);
        int x1 = 0, x2 = 0;
        //Debug.Log(x);
        if (x == 1) {
            while (x1 == x2) {
                x1 = Random.Range(0, 1);
                x2 = Random.Range(1, 2);
            }
                
                gates[x1].gameObject.SetActive(false);
            gates[x2].gameObject.SetActive(false);

        }
        else if (x == 2) {
            int y = Random.Range(0, 2);
            gates[y].gameObject.SetActive(false);
        }
        else {

        }
    }
}
