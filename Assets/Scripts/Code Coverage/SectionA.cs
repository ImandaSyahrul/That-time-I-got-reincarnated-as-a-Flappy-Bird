using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	

	public float luasLimas(float sisiAlas, float tinggiMiring)
	{
		float luas;
		luas = (sisiAlas * sisiAlas) + (4 * (sisiAlas * tinggiMiring / 2));
		return luas;
	}

	public int persamaanLinear(int x)
	{
		int y;
		y = 3 * x - 4;
		return y;
	}

	public int addDetikWithJam(int detik, int hour, int minute, int second)
	{
		int s;

		s = (hour * 3600) + (minute * 60) + second;
		detik = detik + s;
		return detik;
	}

	public int sisaTukarNominalPec1Kdgn50K10K5K(int nominalUang)
	{
		int pec50K, pec10K, pec5K, pec1K;

		pec50K = nominalUang / 50000;
		pec10K = (nominalUang % 50000) / 10000;
		pec5K = ((nominalUang % 50000) % 10000) / 5000;
		pec1K = (((nominalUang % 50000) % 10000) % 5000) / 1000;
		return pec1K;
	}

	public bool isYearKabisat(int idxMonth, int year)
	{
		bool isKabisat;

		isKabisat = ((year % 4 == 0) && (year % 100 > 0)) || (year % 400 == 0);
		return isKabisat;
	}

	public bool isPointOrigin(int x, int y)
	{
		bool isOrigin;

		isOrigin = (x == 0) && (y == 0);
		return isOrigin;
	}

	public bool isPointKuadran1(int x, int y)
	{
		bool isKuadran1;

		isKuadran1 = (x > 0) && (y > 0);
		return isKuadran1;
	}

	public bool isPointKuadran2(int x, int y)
	{
		bool isKuadran2;

		isKuadran2 = (x < 0) && (y > 0);
		return isKuadran2;
	}

	public bool isPointKuadran3(int x, int y)
	{
		bool isKuadran3;

		isKuadran3 = (x < 0) && (y < 0);
		return isKuadran3;
	}

	public bool isPointKuadran4(int x, int y)
	{
		bool isPointKuadran4;

		isPointKuadran4 = (x > 0) && !(y >= 0);
		return isPointKuadran4;
	}

	public bool isPointNotOrigin(int x, int y)
	{
		bool isNotOrigin;

		isNotOrigin = (x != 0) || (y != 0);
		return isNotOrigin;
	}

	public bool isSuhuPadat(int suhu)
	{
		bool isPadat;

		isPadat = (suhu >= 0 && suhu <= 100);
		return isPadat;
	}

	public bool isSuhuCair(int suhu)
	{
		bool isCair;

		isCair = (suhu <= 0);
		return isCair;
	}

	public bool isSuhuUap(int suhu)
	{
		bool isUap;

		isUap = (suhu >= 100);
		return isUap;
	}

}
