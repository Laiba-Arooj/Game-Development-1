using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public int speed = 3;
    public int js = 10;
    public new Rigidbody2D rigidbody;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        float mov = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", mov * speed);
        float movVertical = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector3(mov * speed, movVertical * speed, 0);
        float runspeed = Input.GetAxis("Jump");
        Debug.Log(runspeed);
        if (runspeed >=1)
        {
            rigidbody.velocity = new Vector3(rigidbody.velocity.x, js, 0);
            animator.SetBool("isJump", true);
        }
        else if (runspeed < 0)
        {
            animator.SetBool("isJump", false);
        }
    }
}
