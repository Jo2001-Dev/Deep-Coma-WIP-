using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public oggetti ogg;

    private float horizontal;

    public float speed = 5f;
    private Vector3 target;
    private Vector2 start;
    private Vector3 space;

    private bool canMove;
    private Vector2 last;

    private float current;
    private float newcurrent;
    private bool isFacingRight = true;
    [SerializeField] Transform player;
    [SerializeField] GameObject Saving;


    public Animator animator;
    public bool Walking = false;
    public bool WalkingUp = false;
    public bool WalkingDown = false;

    void Start()
    {
        start = transform.position;
        target = transform.position;
    }

    
    void Update()
    {   
       
       if(Input.GetMouseButtonDown(0))
        {
            canMove = true;
            Walking = true;
        }
       if (canMove == true)
       {
       if(Input.GetMouseButtonDown(0))
        {
           target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

           target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        last = transform.position ;
        
        if((target.y - transform.position.y) > 1)
        {
            WalkingUp = true;
            WalkingDown = false;
            Walking = false;
        }else if((target.y - transform.position.y) < -1f)
        {
            WalkingDown = true;
            Walking = false;
            WalkingUp = false;
        }

        if(target == transform.position)
        {
            Walking = false;
            WalkingUp = false;
            WalkingDown = false;
        }
        if (Walking == true)
        {
           animator.SetBool("Walking", true);
        }
        else if(Walking == false)
        {
           animator.SetBool("Walking", false); 
        }

        if (WalkingUp == true)
        {
           animator.SetBool("WalkingUp", true);
        }
        else if(WalkingUp == false)
        {
           animator.SetBool("WalkingUp", false); 
        }

        if (WalkingDown == true)
        {
           animator.SetBool("WalkingDown", true);
        }
        else if(WalkingDown == false)
        {
           animator.SetBool("WalkingDown", false); 
        }

        

        if((target.x > transform.position.x && isFacingRight) || (target.x < transform.position.x && !isFacingRight))
        {
            Flip();
        }
        
       }
    }
    void Flip()
    {
        isFacingRight = !isFacingRight;
        transform.Rotate(0f, 180f, 0f);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "don't go")
        {

            transform.position = Vector3.MoveTowards(transform.position, start, speed * Time.deltaTime);
            animator.SetBool("Walking", false);
            animator.SetBool("WalkingUp", false);
            animator.SetBool("WalkingDown", false);
            canMove = false;
        }

    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "don't go")
        {

            transform.position = Vector3.MoveTowards(transform.position, start, speed * Time.deltaTime);
            animator.SetBool("Walking", false);
            animator.SetBool("WalkingUp", false);
            animator.SetBool("WalkingDown", false);
            canMove = false;
        }

    }

}
