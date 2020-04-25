using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factorial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public static int factorial(int bilangan)
	{
		int hasil = 0;
		if (bilangan < 0)
		{
			hasil = -1;
		}
		else
		{
			hasil = 1;
			for (int i = bilangan; i > 0; i--)
			{
				hasil = hasil * i;
			}
		}
		return hasil;
	}
}
