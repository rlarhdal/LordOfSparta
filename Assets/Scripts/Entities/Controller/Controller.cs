using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ������Ʈ�� �������� ���� ū Ʋ (event�Լ�)
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
