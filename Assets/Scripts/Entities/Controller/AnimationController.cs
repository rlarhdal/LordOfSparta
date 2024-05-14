using UnityEngine;

// 애니메이터 틀
public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected Controller controller;

    protected virtual void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<Controller>();
    }
}
