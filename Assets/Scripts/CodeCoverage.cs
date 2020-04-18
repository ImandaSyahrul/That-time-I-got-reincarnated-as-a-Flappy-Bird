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
        //Kebutuhan testing fitur code coverage
        if (Input.GetKeyDown(KeyCode.D))
        {
            dCounter++;
            switch (dCounter)
            {
                case 5:Debug.Log("d 5 times");break;
                case 10: Debug.Log("d 10 times"); break;
                case 20: Debug.Log("d 20 times"); break;
                default: Debug.Log("clicking D key");break;
            }
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            fCounter++;
            switch (fCounter)
            {
                case 5: Debug.Log("f 5 times"); break;
                case 10: Debug.Log("f 10 times"); break;
                case 20: Debug.Log("f 20 times"); break;
                default: Debug.Log("clicking F key"); break;
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

        switch (idleCounter)
        {
            case 5: 
                switch (dCounter)
                {
                    case 5: Debug.Log("all counter count at 5");break;
                    default: Debug.Log("waiting for sync");break;
                }break;
            case 10:
                switch (dCounter)
                {
                    case 10: Debug.Log("all counter count at 10"); break;
                    default: Debug.Log("waiting for sync"); break;
                }
                break;
            default: break;
        }
    }
}
