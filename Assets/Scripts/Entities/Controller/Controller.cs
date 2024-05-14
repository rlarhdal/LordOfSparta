using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 게임 오브젝트의 움직임을 위한 큰 틀 (event함수)
public class Controller : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }
}
