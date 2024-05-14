using UnityEngine;
using UnityEngine.InputSystem;

// 이동에 필요한 값 전달
public class PlayerInputController : Controller
{
    private Camera _camera;
    public Vector2 newAim;

    private void Awake()
    {
        _camera = Camera.main;
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized; // 이동키를 눌렀을 때 움직임을 normalized 해서 방향으로 만듬
        CallMoveEvent(moveInput);
    }

    public void OnLook(InputValue value)
    {
        newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized; 

        if(newAim.magnitude >= .9)
        {
            // Vector 값을 실수로 변환
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        //Debug.Log("OnFire" + value.ToString());
    }
}
