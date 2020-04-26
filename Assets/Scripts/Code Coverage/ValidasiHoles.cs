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

    public void countHoles(string sentence)
    {
        int i;
        for (i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == 'A' || sentence[i] == 'D' ||
              sentence[i] == 'O' || sentence[i] == 'P' ||
              sentence[i] == 'Q' || sentence[i] == 'R')
            {
                jumlahLubang = jumlahLubang + 1;
            }
            else if (sentence[i] == 'B')
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
