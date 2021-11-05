using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
	private Rigidbody2D rb;
	public float speed;
	public float jumpForce;
	public GameObject PlayerPrefab;
	private SpriteRenderer sr;
    private bool groundJump;
    private bool entityJump;
	public Transform feet;
	public float checkRadius;
	public LayerMask groundLayer;
    public LayerMask entityLayer;

	//public float horizontalMove;
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
    	/*float xMovement = Input.GetAxis("Horizontal");
    	 (xMovement > 0){
    		sr.flipX = false;
    	}else if (xMovement < 0){
    		sr.flipX = true;
    	}*/
    	if(Input.GetKey(KeyCode.D)){
    		transform.Translate(speed*Time.deltaTime, 0, 0);
    		sr.flipX = false;
    	}
    	if(Input.GetKey(KeyCode.A)){
    		transform.Translate(-speed*Time.deltaTime, 0, 0);
    		sr.flipX = true;
    	}
    	/*if(Input.GetKeyDown(KeyCode.W)){
    		transform.Translate(0,Time.deltaTime*50,0);
    	}*/
    	if(Input.GetKeyDown(KeyCode.Z)){
			SpawnEntity();
    	}
    	groundJump = Physics2D.OverlapCircle(feet.position, checkRadius, groundLayer);
    	if (groundJump == true && Input.GetKeyDown(KeyCode.W)){
    		rb.velocity = Vector2.up * jumpForce;
    	}
        entityJump = Physics2D.OverlapCircle(feet.position, checkRadius, entityLayer);
        if (entityJump == true && Input.GetKeyDown(KeyCode.W)){
            rb.velocity = Vector2.up * jumpForce;
        }
    	//horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
    }//Quaternion Mathematics    	
    	/*public void UseItem(){
    		Debug.Log("MOVING")
    	}*/
        	public void SpawnEntity(){
    		GameObject Player = Instantiate(PlayerPrefab, Vector3.zero, Quaternion.identity);
			Player.GetComponent<Playermovement>().enabled = false;
    	}
}

