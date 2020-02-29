using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
	//Global Variables
	[SerializeField] private float upForce = 100;
	[SerializeField] private bool isDead;
	[SerializeField] private UnityEvent OnJump, OnDead;

	[SerializeField] private int score;
	[SerializeField] private UnityEvent OnAddPoint;
	[SerializeField] private UnityEvent OnFifthy, OnTen, OnTwentyFive;

	[SerializeField] private Text scoreText;

	//Untuk controller yang selalu berganti
	private int nextClick;
	private string nextKey;

	private Animator animator;
	private Rigidbody2D rigidBody2d;

	//init variable
	void Start()
	{
		//Mendapatkan komponent ketika game baru berjalan
		rigidBody2d = GetComponent<Rigidbody2D>();
		//Mendapatkan komponen animator pada game object   
		animator = GetComponent<Animator>();

		nextClick = 0;
		nextKey = "f";
	}
	
	//Update setiap frame  
	void Update()
	{

		
		//Melakukan pengecekan jika belum mati dan klik kiri pada mouse atau space
		if (!isDead && ( Input.GetMouseButtonDown(nextClick) || Input.GetKeyDown(nextKey)))
		{
			//Burung meloncat
			Jump();

			if (nextClick == 0) // menambah difficulty
			{
				nextClick = 1;
				nextKey = "d";
			}
			else
			{
				nextClick = 0;
				nextKey = "f";
			}
		}
		float angle = Vector3.Angle(Vector3.right, rigidBody2d.velocity);
		if (rigidBody2d.velocity.y < 0)
			angle = -angle/2;
		transform.eulerAngles = new Vector3(0, 0, angle/2);
	}
	//Fungsi untuk mengecek sudah mati apa belum
	public bool IsDead()
	{
		return isDead;
	}

	//Membuat Burung Mati
	public void Dead()
	{
		//Pengecekan jika belum mati dan value OnDead tidak sama dengan Null
		if (!isDead && OnDead != null)
		{
			//Memanggil semua event pada OnDead
			OnDead.Invoke();
		}

		//Mengeset variable Dead menjadi True
		isDead = true;

	}

	void Jump()
	{
		//Mengecek rigidbody null atau tidak
		if (rigidBody2d)
		{
			//menghentikan kecepatan burung ketika jatuh
			rigidBody2d.velocity = Vector2.zero;

			//Menambahkan gaya ke arah sumbu y agar burung meloncat
			rigidBody2d.AddForce(new Vector2(0, upForce));

		}

		//Pengecekan Null variable
		if (OnJump != null)
		{
			//Menjalankan semua event OnJump event
			OnJump.Invoke();
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		//menghentikan Animasi Burung ketika bersentukan dengan object lain
		animator.enabled = false;
	}

	public void AddScore(int value)
	{
		//Menambahkan Score value
		score += value;

		//Pengecekan Null Value
		if (OnAddPoint != null)
		{
			//Memanggil semua event pada OnAddPoint
			OnAddPoint.Invoke();
		}

		//Mengubah nilai text pada score text
		scoreText.text = score.ToString();
	}

	public void Multiple()
	{
		if (score == 10)
		{
			OnTen.Invoke();
		}
		if (score == 25)
		{
			OnTwentyFive.Invoke();
		}
		if (score == 50)
		{
			OnFifthy.Invoke();
		}
	}
}
