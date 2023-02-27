using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "TutorialPrompt", menuName = "buttongame-unity/TutorialPrompt", order = 0)]
public class TutorialPrompt : ScriptableObject 
{
    [SerializeField] private string _header;
    [SerializeField] private List<string> _content = new List<string>();
    [SerializeField] private Image _image;
}
