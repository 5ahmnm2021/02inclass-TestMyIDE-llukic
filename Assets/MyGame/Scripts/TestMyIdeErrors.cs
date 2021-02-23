using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestMyIdeErrors : MonoBehaviour
{
    string Tag = "TestMyIdeErrors";

    // Update is called once per frame
    void Update()
    {

    }
    int a = 1;
    int b = 2;
    int c = 3;
    float d = 5;

    TextMeshProUGUI TextPro;

    // Start is called before the first frame update
    void Start()
    {
        int c = a + b;
        Debug.Log(message:"a + b = c");
        Debug.Log(Tag + "- Done ;)");
    }

  
}