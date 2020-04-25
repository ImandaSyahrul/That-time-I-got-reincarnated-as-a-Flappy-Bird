using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	public void OutputBintang_42(int N)
	{
		// Output bintang dilakukan jika N bernilai positif
		int i;

		if (N > 0)
		{
			for (i = 1; i <= N; i++)
			{
				Debug.Log("*");
			}
		}
		else
		{
			Debug.Log("N invalid, harus bernilai positif");
		}
	}

	public bool isBilPrima_43(int bil)
	{
		bool isPrima = false;
		int temp;

		if (bil > 1)
		{
			temp = bil - 1;
			while (temp > 1 && isPrima == false)
			{
				if (bil % temp == 0)
				{
					isPrima = true;
				}
				temp = temp - 1;
			}
		}
		return isPrima;
	}

	public int[] pengurutanBilangan_44(int[] bil, int N)
	{
		int i, k, temp;
		if (N > 0)
		{
			k = N - 1;
			do
			{
				for (i = 0; i <= k; i++)
				{
					if (bil[i] > bil[i + 1])
					{
						temp = bil[i];
						bil[i] = bil[i + 1];
						bil[i + 1] = temp;
					}
				}
				k = k - 1;
			} while (k > 0);
		}

		return bil;
	}

	public String isAdaBil_45(int[] bil, int N, int cari)
	{
		// pre kondisi N adalah panjang array bilangan
		String status = "tidak ketemu";
		int i;

		if (N > 0)
		{
			status = "Deretan Bilangan Kosong";
		}
		else
		{
			for (i = 0; i < N; i++)
			{
				if (bil[i] == cari)
				{
					status = "bilangan ketemu";
				}
			}
		}

		return status;

	}
	public float calPangkatDua_46_47(int bil, int pangkat)
	{
		float result = 1;
		int temp, i;

		if (bil == 0 && pangkat > 0)
		{
			result = 0;
		}
		else if (pangkat > 0)
		{
			i = 0;
			do
			{
				result = result * bil;
				i = i + 1;
			}
			while (i < pangkat);
		}
		else if (pangkat < 0)
		{
			if (bil != 0)
			{
				i = 0;
				while (i < pangkat)
				{
					result = result * 1 / bil;
					i = i + 1;
				}
			}
			else
			{
				result = -99999;
			}
		}
		else
		{ // pangkat = 0
			if (bil == 0)
			{
				result = -99999;
			}
		}
		return result;
	}

	public int[] desimalToBiner_48(int bil)
	{
		// panjang array yang dikembalikan adalah 10
		// Ilustrasi :
		// desimal = 11 --> biner = 0000001011
		// desimal = 0  --> biner = 0000000000
		// desimal < 0  --> biner = tidak terdefinisi (diisi dengan -1-1-1-1-1-1-1-1-1-1

		int[] biner = new int[10];
		int calTemp, idx;

		if (bil >= 0)
		{
			if (bil == 0)
			{
				idx = 10;
			}
			else
			{
				calTemp = bil;
				idx = 9;
				while (calTemp != 1)
				{
					biner[idx] = calTemp % 2;
					calTemp = calTemp / 2;
					idx = idx - 1;
				}
				biner[idx] = calTemp;
			}
			for (idx = idx - 1; idx >= 0; idx--)
			{
				biner[idx] = 0;
			}
		}
		else
		{
			for (idx = 1; idx < 10; idx++)
			{
				biner[idx] = -1;
			}
		}
		return biner;
	}

	public int GetIndexByElemen_49(int[] bil, int N, int cari)
	{
		// cari index by elemen
		// jika elemen bernilai negatif --> return -1
		// jika elemen bernilai nol --> return 0
		// jika elemen tidak ketemu --> return -2
		// jika elemen ketemu --> return indexnya

		int i, idx;
		bool ketemu = false;

		idx = 0;
		if (N > 0)
		{
			if (cari <= 0)
			{
				if (cari < 0)
				{
					idx = -1;
				}
			}
			else
			{
				idx = -2;
				i = 0;
				while (i < N || ketemu == true)
				{
					if (bil[i] == cari)
					{
						ketemu = true;
						idx = i;
					}
					i = i + 1;
				}
			}
		}
		return (idx);
	}

	public int GetElemenTerbesar_50(int[] bil, int N)
	{
		// nilai N adalah jumlah bil
		// prekondisi jumlah deretam pada array bil sama dengan nilai N
		// cari elemen terbesar dari deretan bilangan
		// jika jumlah deret bilangan bernilai negatif --> return -1
		// jika jumlah deret bilangan bernilai nol --> return 0
		// jika jumlah deret bilangan lebih besar dari nol --> return max bilnya

		int i, idx, max;
		bool ketemu = false;

		max = 0;
		if (N <= 0)
		{
			if (N < 0)
			{
				max = -1;
			}
		}
		else
		{
			idx = -2;
			i = 0;
			do
			{
				if (bil[i] > max)
				{
					max = bil[i];
				}
				i = i + 1;
			} while (i < N);
		}
		return (max);
	}
}
