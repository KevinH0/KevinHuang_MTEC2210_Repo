using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
	public float speed = 20f;
	public float horizontalMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
    }
}
