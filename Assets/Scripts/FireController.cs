using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireController : MonoBehaviour
{
    [SerializeField] public Bullet bullet;
    [SerializeField] public int ammo;
    [SerializeField] public Text ammotext;

    // Start is called before the first frame update
    void Start()
    {
        ammotext.text = ammo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ammo > 0)
            {
                Bullet fire = Instantiate(bullet, transform.position, Quaternion.identity);
                ammo--;
                ammotext.text = ammo.ToString();
            }
            
        }
    }
}
