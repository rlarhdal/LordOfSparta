using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviour //lobbymanager랑 buttonmanager 합칠 예정 -> uimanager
{
    public Text inputText;

    [SerializeField]
    private Button enterBtn;
    [SerializeField]
    private Image[] characterImgs;

    public static LobbyManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;
    }

    private void Start()
    {
        UpdateImg();
    }

    private void Update()
    {
        CheckTextLength(enterBtn);
    }

    /// <summary>
    /// 닉네임 길이 확인
    /// </summary>
    public void CheckTextLength(Button button)
    {
        int txtLength = inputText.text.Length;
        bool isCheck = txtLength < 11 && txtLength >= 2;
        button.interactable = isCheck;
    }

    public void Choice(int num)
    {
        ButtonManager.instance.ChoiceCharacter(num);
        UpdateImg();
    }

    private void UpdateImg()
    {
        switch (DataManager.Instance.currentCharacter)
        {
            case Character.Red:
                characterImgs[0].gameObject.SetActive(true);
                characterImgs[1].gameObject.SetActive(false);
                break;
            case Character.Orange:
                characterImgs[0].gameObject.SetActive(false);
                characterImgs[1].gameObject.SetActive(true);
                break;
        }
    }
}
