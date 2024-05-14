using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public static ButtonManager instance;

    private Character character;

    [SerializeField]
    private GameObject choicePanel;
    [SerializeField]
    private GameObject nickPanel;
    [SerializeField]
    private InputField idInputField;
    [SerializeField]
    private Button enterBtn;

    bool isTyping = false;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this);
        }
        instance = this;
    }

    private void Update()
    {
        if (isTyping)
        {
            LobbyManager.instance.CheckTextLength(enterBtn);
        }
    }

    public void ChoiceCharacter(int num)
    {
        switch (num)
        {
            case 0:
                character = Character.Red;
                break;
            case 1:
                character = Character.Orange;
                break;

        }
        DataManager.Instance.currentCharacter = character;
        choicePanel.SetActive(false);
    }

    public void NickNamePanel()
    {
        isTyping = true;
        nickPanel.SetActive(true);
        GameManager.instance.player.SetActive(false);
        idInputField.text = DataManager.Instance.nickName;
    }

    public void CompletedChanging()
    {
        isTyping = false;
        DataManager.Instance.nickName = idInputField.text;
        GameManager.instance.player.SetActive(true);
        GameManager.instance.nickName.text = DataManager.Instance.nickName;
        nickPanel.SetActive(false);
    }
}
