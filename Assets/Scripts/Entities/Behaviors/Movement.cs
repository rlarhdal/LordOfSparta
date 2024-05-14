using System;
using UnityEngine;

// 실제 움직임이 발생하는 부분
public class Movement : MonoBehaviour
{
    private Controller movementController;
    private Rigidbody2D rigid;

    private Vector2 movementDir = Vector2.zero; // 처음은 제로로 시작

    private void Awake()
    {
        //같은 게임오브젝트의 controller, rigidbody 가져올 것
        movementController = GetComponent<Controller>();
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        //onmoveevent에 move를 호출하라고 등록
        movementController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // 물리 업데이트에서 움직임 적용
        ApplyMovement(movementDir);
    }

    private void Move(Vector2 direction)
    {
        // 이동방향만 정해두고 실제로 움직이지 않음
        // 움직이는 것은 물리 업데이트에서 진행
        movementDir = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        rigid.velocity = direction; //velocity : 속도
    }
}
