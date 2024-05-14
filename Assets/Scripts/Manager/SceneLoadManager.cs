using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoadManager : MonoBehaviour
{
    public static SceneLoadManager instance;

    [SerializeField]
    private Button button;

    private void Awake()
    {
        if(instance != null) 
        {
            Destroy(gameObject);
        }
        instance = this;

        button = GetComponent<Button>();
    }

    public void StartGame()
    {
        SceneManager.LoadScene("LobbyScene");
    }

    public void EnterGame()
    {
        DataManager.Instance.nickName = LobbyManager.instance.inputText.text;
        SceneManager.LoadScene("MainScene");
    }
}
