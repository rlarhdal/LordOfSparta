using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueController : MonoBehaviour
{
    [SerializeField]
    Text targetText;

    DialogueSO currentDialogue;
    int currentTextLine;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            PushText();
        }
    }

    private void PushText()
    {
        currentTextLine += 1;
        if(currentTextLine > currentDialogue.line.Count)
        {
            Conclude();
        }
        else
        {
            targetText.text = currentDialogue.line[currentTextLine];
        }
    }
    public void Initialize(DialogueSO dialogueSO)
    {
        Show(true);
        currentDialogue = dialogueSO;
        currentTextLine = 0;
        targetText.text = currentDialogue.line[currentTextLine];
    }


    private void Show(bool v)
    {
        gameObject.SetActive(v);
    }

    private void Conclude()
    {
        Show(false);
        Debug.Log("Dialoue test // Stickcode post");
    }
}
