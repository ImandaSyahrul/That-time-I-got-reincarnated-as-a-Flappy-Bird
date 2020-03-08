using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float speed; //kecepatan peluru


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = transform.right*speed*10f;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //menghancurkan pipe
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }else if (collision.gameObject.CompareTag("Boundary"))
        {
            Destroy(gameObject);
        }
            
    }
}
