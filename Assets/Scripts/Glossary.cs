using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glossary : MonoBehaviour
{
	private bool b =false;
	public GameObject Hosni;
	public GameObject Beard;
	public GameObject Hair;
	public GameObject Face;
	public Color Haircolor;
	public Color Beardcolor;
	public Color Facecolor;

    void Start()
    {
        //Haircolor = GameObject.Find("Hair").GetComponent<SpriteRenderer>().color;
        GameObject.Find("Hair").GetComponent<SpriteRenderer>().color = Color.red;

        //Beardcolor = GameObject.Find("Beard").GetComponent<SpriteRenderer>().color;
        GameObject.Find("Beard").GetComponent<SpriteRenderer>().color = Color.green;

        //Facecolor = GameObject.Find("Face").GetComponent<SpriteRenderer>().color;
        GameObject.Find("Face").GetComponent<SpriteRenderer>().color = Color.blue;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
