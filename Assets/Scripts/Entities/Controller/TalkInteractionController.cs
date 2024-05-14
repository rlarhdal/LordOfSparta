using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkInteractionController : Interactable
{
    [SerializeField] DialogueSO dialogueSO;
    
    public override void Interact(Player player)
    {
        Debug.Log("¼º°ø");
        GameManager.instance.dialogueController.Initialize(dialogueSO);
        StartCoroutine(WaitForIt());
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(2.0f);
    }
}
