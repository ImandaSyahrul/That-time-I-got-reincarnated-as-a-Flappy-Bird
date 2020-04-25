using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidasiHoles : MonoBehaviour
{

    private int jumlahLubang;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void countHoles(String sentence)
    {
        int i;
        for (i = 0; i < sentence.length(); i++)
        {
            if (sentence.charAt(i) == 'A' || sentence.charAt(i) == 'D' ||
              sentence.charAt(i) == 'O' || sentence.charAt(i) == 'P' ||
              sentence.charAt(i) == 'Q' || sentence.charAt(i) == 'R')
            {
                jumlahLubang = jumlahLubang + 1;
            }
            else if (sentence.charAt(i) == 'B')
            {
                /* lubang di huruf B ada dua, 
                    perlu treatment khusus :) */
                jumlahLubang = jumlahLubang + 2;
            }
        }
    }

    public int getJumlahLubang()
    {
        return jumlahLubang;
    }
}
