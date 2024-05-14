using System;
using UnityEngine;

public class AimRotation : MonoBehaviour
{
    [SerializeField] private Transform armPivot;
    [SerializeField] private Transform weaponPivot;
    [SerializeField] private SpriteRenderer charaterRenderer;
    [SerializeField] private SpriteRenderer weaponRenderer;

    private Controller _controller;

    private void Awake()
    {
        _controller = GetComponent<Controller>();
    }

    private void Start()
    {
        // 마우스의 위치가 들어오는 OnLookEvent에 등록하는 것
        _controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 newAimDir)
    {
        // onlook
        RotateArm(newAimDir);
    }

    private void RotateArm(Vector2 dir)
    {
        float rotZ = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        bool isFlipped = Mathf.Abs(rotZ) > 90f;

        // [1.캐릭터 뒤집기]
        charaterRenderer.flipX = isFlipped;
        // [2. 팔 돌리기]
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);

        if(isFlipped)
        {
            weaponRenderer.flipY = true;

        }
    }
}