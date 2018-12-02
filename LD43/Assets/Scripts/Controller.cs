using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public float jumpforce;
    
    public float fallmultiplier = 2.5f;
    public float lowJumpmultiplier = 2f;

    private bool mov_right, mov_left, mov_jump;

    private void Awake()
    {
 
        gameObject.name = "Player";
    }
    void Start () {
        rb = gameObject.GetComponent<Rigidbody>();
	}
	
	void Update () {
		if(Input.GetKey(KeyCode.D))
        {
            mov_right = true;
        } else
        {
            mov_right = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            mov_left = true;
        }
        else
        {
            mov_left = false;
        }

        if (Input.GetButtonDown ("Jump") && grounded())
        {
            rb.velocity = Vector3.up * jumpforce;
        }

    }

    private void FixedUpdate()
    {
        if (mov_right)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if(mov_left)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }
    private void LateUpdate()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics2D.gravity.y * (fallmultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            rb.velocity += Vector3.up * Physics2D.gravity.y * (lowJumpmultiplier - 1) * Time.deltaTime;
        }
    }
    bool grounded()
    {
        return Physics.Raycast(transform.position, Vector3.down, 1.25f);
    }
}
