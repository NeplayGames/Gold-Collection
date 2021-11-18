using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    float horizontal;
    float vertical;
    float perFrameTime;
    // Update is called once per frame
    void Update()
    {
        perFrameTime = Time.deltaTime;
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        if (horizontal == 0 && vertical == 0)
        {
            animator.ResetTrigger("linear");
            animator.ResetTrigger("side");
            animator.SetTrigger("idle");
            return;
        }
        if (Mathf.Abs(vertical) > 0)
        {
            PlayerForwardBackwardMovement();
        }

        if (Mathf.Abs(horizontal) > 0)
        {
            PlayerLeftRightMovement();

        }
    }


    ///<summary>
    ///Function let player moves forward and backward
    ///</summary>
    private void PlayerForwardBackwardMovement()
    {
        animator.ResetTrigger("idle");
        animator.ResetTrigger("side");
        animator.SetTrigger("linear");
        if (vertical < 0)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 180, 0), 19 * perFrameTime);
            if (Mathf.Abs(transform.eulerAngles.y - 180) < 12)
            {
                transform.rotation = Quaternion.Euler(0, -180, 0);
            }
            animator.SetFloat("Locomotion", 1);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 0, 0), 19 * perFrameTime);
            if (Mathf.Abs(transform.eulerAngles.y - 0) < 12)
            {
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        transform.position = transform.position + Vector3.forward * vertical * speed * perFrameTime;
        animator.SetFloat("Locomotion", 1);
    }

     ///<summary>
    ///Function let player moves Right and left
    ///</summary>
    private void PlayerLeftRightMovement()
    {
        animator.ResetTrigger("idle");
        animator.ResetTrigger("linear");
        animator.SetTrigger("side");
        animator.SetFloat("sideWays", horizontal);
        transform.position = transform.position + transform.right * horizontal * speed * perFrameTime;
    }

}
