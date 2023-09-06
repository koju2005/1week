using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    PlayerMoveController controller;
    Rigidbody2D rigidbody;
    private Vector2 Playerdir = Vector2.zero;
    Animator animator;
    SpriteRenderer sprite;
    public float Speed;
    public AudioSource audioSource;
    private void Awake()
    {
        controller = GetComponent<PlayerMoveController>();
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
       
    }

    private void Start()
    {
        controller.OnMoveEvent += GoMove;
    }
    public void Update()
    {
        if (animator.GetBool("IsMoving"))
        {
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
    }
    private void FixedUpdate()
    {
        ApplyGoMove(Playerdir);
        if(Mathf.Approximately(Playerdir.x,0)&& Mathf.Approximately(0, Playerdir.y))
        {
            animator.SetBool("IsMoving",false);
            sprite.flipX = false;
        }
        else
        {
            animator.SetBool("IsMoving", true);
        }
      
        animator.SetFloat("x",Playerdir.x);
        animator.SetFloat("y", Playerdir.y);
    
    }
    private void GoMove(Vector2 dir)
    {
        Playerdir = dir;
    }

    private void ApplyGoMove(Vector2 dir)
    {
        dir *= 5;
        rigidbody.velocity = dir*Speed;
    }

}
