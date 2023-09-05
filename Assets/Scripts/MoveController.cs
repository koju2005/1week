using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;

    public void CallOnMove(Vector2 dir)
    {
        OnMoveEvent?.Invoke(dir);
    }
}
