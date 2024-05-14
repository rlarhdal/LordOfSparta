using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("# Player")]
    //[SerializeField] private Transform playerTransform;
    //[SerializeField] private SpriteRenderer playerSprite;
    public GameObject player;
    [SerializeField] private GameObject[] charPrefabs;
    private Vector3 playerPos = Vector3.zero;

    [Header("# UI")]
    public Text nickName;
    private Image nickNamePanel;
    [SerializeField]
    private Text timeText;
    [SerializeField]
    private Image listPanel;
    [SerializeField]
    private Image rightPanel;
    public DialogueController dialogueController;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        instance = this;

        Init();
    }

    // Update is called once per frame
    void Update()
    {
        nickNamePanel.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);
        CurrentTime();
    }

    private void Init()
    {
        player = Instantiate(charPrefabs[(int)DataManager.Instance.currentCharacter]);
        nickName = player.GetComponentInChildren<Text>();
        nickNamePanel = player.GetComponentInChildren<Image>();

        player.transform.position = playerPos;
        nickName.text = DataManager.Instance.nickName;
    }

    public void ChangeCharacter(int num)
    {
        player.SetActive(false);
        ButtonManager.instance.ChoiceCharacter(num);

        playerPos = player.transform.position;
        Destroy(player);
        Init();
    }

    private void CurrentTime()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
    }

    public void OpenList()
    {
        InitList();
    }

    public void InitList()
    { 
        rightPanel.gameObject.SetActive(true);
    }
}
