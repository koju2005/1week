using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoveController : MoveController
{
   public Camera camera;
    private void Awake()
    {
        camera = Camera.main;
    }

    private void OnMove(InputValue val)
    {
        Vector2 move = val.Get<Vector2>();
        CallOnMove(move);
    }
}
