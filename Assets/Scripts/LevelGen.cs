using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGen : MonoBehaviour
{
    public GameObject[] section;
    public List<GameObject> objects = new List<GameObject>();
    public int zPos = 50;
    public bool creatingSection = false;
    public int secNum;
    public int sec = 3;
    void Update()
    {
        if (creatingSection == false) {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection() {
        secNum = Random.Range(0,3);
        var o = Instantiate(section[secNum], new Vector3(0,0,zPos), Quaternion.identity);
        objects.Add(o);
        zPos += 40;
        //Debug.Log(objects.Count);
        if (objects.Count > 8) {
            Destroy(objects[0].gameObject);
            objects.RemoveAt(0);
        }
        if (sec == 8) {
            for (int i = 0; i < 4; i++) {
                Destroy(objects[0].gameObject);
                objects.RemoveAt(0);
            }
        }
        if (objects.Count < 8) {
            sec = 3;
        } else {
            sec = 8;
        }
        yield return new WaitForSeconds(sec);
        creatingSection = false;
    }
}
