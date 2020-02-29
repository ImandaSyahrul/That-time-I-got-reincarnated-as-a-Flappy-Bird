using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] public GameObject paral1;
    [SerializeField] public GameObject paral2;
    public GameObject layer1;
    public GameObject layer2;
    public GameObject newLayer1;
    public GameObject newLayer2;
    private Vector3 layer1Pos;
    private Vector3 layer2Pos;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        layer1Pos = paral1.transform.position;
        layer2Pos = paral2.transform.position;
        layer1 = Instantiate(paral1, layer1Pos, Quaternion.identity);
        layer1.SetActive(true);
        layer2 = Instantiate(paral2, layer2Pos, Quaternion.identity);
        layer2.SetActive(true);
        newLayer1 = Instantiate(paral1.gameObject, layer1Pos+ new Vector3(19.5f, 0, 0), Quaternion.identity);
        newLayer1.SetActive(true);
        newLayer2 = Instantiate(paral2.gameObject, layer2Pos+ new Vector3(14.8f, 0, 0), Quaternion.identity);
        newLayer2.SetActive(true);
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Efek parallax sederhana
        layer1.GetComponent<Transform>().Translate(new Vector3 (-0.2f * Time.deltaTime, 0, 0));
        newLayer1.GetComponent<Transform>().Translate(new Vector3(-0.2f * Time.deltaTime, 0, 0));
        layer2.GetComponent<Transform>().Translate(new Vector3(-0.05f * Time.deltaTime, 0, 0));
        newLayer2.GetComponent<Transform>().Translate(new Vector3(-0.05f * Time.deltaTime, 0, 0));
        if (layer1.transform.position.x < -19.5f)
        {
            Destroy(layer1.gameObject);
            layer1 = newLayer1;
            newLayer1 = Instantiate(paral1, layer1Pos + new Vector3(19.5f, 0, 0), Quaternion.identity);
            if (!newLayer1.gameObject.activeInHierarchy) newLayer1.SetActive(true);
        }
        if (layer2.transform.position.x < -14.8f)
        {
            Destroy(layer2.gameObject);
            layer2 = newLayer2;
            newLayer2 = Instantiate(paral2, layer2Pos + new Vector3(14.8f, 0, 0), Quaternion.identity);
            if (!newLayer2.gameObject.activeInHierarchy) newLayer2.SetActive(true);
        }
    }
}
