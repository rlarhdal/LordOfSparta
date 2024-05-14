using System;
using UnityEngine;

public class PlayerInteractController : MonoBehaviour
{
    PlayerInputController playerController;
    Rigidbody2D rigid;

    [SerializeField]
    float offsetDistance = 1f;
    [SerializeField]
    float sizeOfInteractableArea = 1.2f;

    Player player;

    private void Awake()
    {
        playerController = GetComponent<PlayerInputController>();
        rigid = GetComponent<Rigidbody2D>();
        player = GetComponent<Player>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    private void Interact()
    {
        Vector2 pos = rigid.position + playerController.newAim * offsetDistance;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(pos, sizeOfInteractableArea);

        foreach(Collider2D collider in colliders)
        {
            Interactable hit = collider.GetComponent<Interactable>();
            if(hit != null)
            {
                hit.Interact(player);
                break;
            }
        }
    }
}