using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeCoverage : MonoBehaviour
{
    private int dCounter;
    private int fCounter;
    private int idleCounter;
    // Start is called before the first frame update
    void Start()
    {
        dCounter = 0;
        fCounter = 0;
        idleCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            dCounter++;
            switch (dCounter)
            {
                case 5:Debug.Log("5 times");break;
                case 10: Debug.Log("10 times"); break;
                case 20: Debug.Log("20 times"); break;
                default: Debug.Log("clicking D key");break;
            }
        }
        else
        {
            idleCounter++;
            switch (idleCounter)
            {
                case 5: Debug.Log("idle 5 times"); break;
                case 10: Debug.Log("idle 10 times"); break;
                case 20: Debug.Log("idle 20 times"); break;
                default: Debug.Log("idle");break;
            }
        }
    }
}
