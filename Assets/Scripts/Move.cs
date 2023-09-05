using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    PlayerMoveController controller;
    Rigidbody2D rigidbody;
    private Vector2 Playerdir = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<PlayerMoveController>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += GoMove;
    }
    private void FixedUpdate()
    {
        ApplyGoMove(Playerdir);
    }
    private void GoMove(Vector2 dir)
    {
        Playerdir = dir;
    }

    private void ApplyGoMove(Vector2 dir)
    {
        dir *= 5;
        rigidbody.velocity = dir;
    }
}
