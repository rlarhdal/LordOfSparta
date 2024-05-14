using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character
{
    Red, Orange
}

public enum Job
{
    Manager, Tutor
}

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    public Character currentCharacter = Character.Red;

    public GameObject player;
    public string nickName;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
