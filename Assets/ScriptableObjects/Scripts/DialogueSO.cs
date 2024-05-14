using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DialogueSO", menuName = "ScriptableObject/DialogueSO", order = 0)]

public class DialogueSO : ScriptableObject
{
    public List<string> line;
    public NpcSO npc;
}
