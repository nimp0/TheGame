using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Animator animator;
    public Rigidbody rb;

    private float horizontal;
    private float vertical;
    private bool run;
    private bool jump;

    void Start ()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        run = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}

    void Move()
    {
        if (Input.GetKey(KeyCode.LeftShift)) run = true;
        else run = false;

        if (Input.GetKey(KeyCode.Space)) jump = true;
        else jump = false;

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        animator.SetFloat("horizontal", horizontal);
        animator.SetFloat("vertical", vertical);
        animator.SetBool("run", run);
        animator.SetBool("jump", jump);

        float moveX = horizontal * 20f * Time.deltaTime;
        float moveZ = vertical * 50f * Time.deltaTime;
        
        if (run) { moveZ *= 4; moveX *= 4; }
        
        rb.velocity = new Vector3(moveX, 0, moveZ);
    }
}
