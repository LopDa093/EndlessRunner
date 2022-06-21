using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    public GameObject[] section;
    public List<GameObject> objects = new List<GameObject>();
    public int counter = 9;
    public int zPos = 50;
    public bool creatingSection = false;
    public int secNum;
    public int sec = 4;

    private void Start() {
        /*
        GameObject[] temp = new GameObject[section.Length];
        for (int i = 0; i < section.Length; i++) {
            temp[i] = section[i];
        }

        for (int j = temp.Length - 1; j > 0; j--) {
            secNum = Random.Range(0, temp.Length);
            objects.Add(secNum);
        }

        for (int k = 0; k < objects.Count; k++) {
            section[objects[k]].transform.position = new Vector3(0, 0, zPos);
            zPos += 40;
        }*/
    }
    void Update()
    {
        if (creatingSection == false) {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
        
    }

    IEnumerator GenerateSection() {
        
        secNum = Random.Range(0,2);
        var o = Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity);
        objects.Add(o);
        zPos += 40;
        //Debug.Log(objects.Count);
        if (objects.Count > 3) {
            Destroy(objects[0].gameObject);
            objects.RemoveAt(0);
        }
        if (sec == 8) {
            for (int i = 0; i < 4; i++) {
                Destroy(objects[0].gameObject);
                objects.RemoveAt(0);
            }
        }
        if (objects.Count < 4) {
            sec = 4;
        } else {
            sec = 8;
        }
        /*
        Debug.Log(section.Length);
        for (int i = 0; i < counter; i++) {
            secNum = Random.Range(0, 9);
            bool alreadyUsed = false;
            for (int j = 0; j < objects.Count; j++) {
                if (secNum == objects[j]) {
                    alreadyUsed = true;
                }
            }
            if (alreadyUsed == false) {
                objects.Add(secNum);
            }
            else {
                counter++;
            }
        }
        for (int i = 0; i < 9; i++) {
            section[objects[i]].transform.position = new Vector3(0, 0, zPos);
            zPos += 40;
        }*/
        /*
        List<int> tmp = new List<int>();
        for (int i = 0; i < section.Length; i++) {
            tmp.Add(i);
        }
        Debug.Log(tmp[2]);
        Debug.Log(tmp[7]);
        for (int j = 0; j < tmp.Count; j++) {
            secNum = Random.Range(0, tmp.Count-1);
            objects.Add(tmp[secNum]);
            tmp.RemoveAt(tmp.IndexOf(secNum));
        }

        for (int k = 0; k < objects.Count; k++) {
            section[objects[k]].transform.position = new Vector3(0, 0, zPos);
            zPos += 40;
        }
        */
        yield return new WaitForSeconds(4);
        creatingSection = false;
    }
}
