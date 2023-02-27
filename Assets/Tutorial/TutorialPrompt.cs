using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "TutorialPrompt", menuName = "buttongame-unity/TutorialPrompt", order = 0)]
public class TutorialPrompt : ScriptableObject 
{
    [SerializeField] private string _header;
    public string Header => _header;

    [SerializeField] private List<string> _content = new List<string>();
    public List<string> Content => _content;

    [SerializeField] private Image _image;
    public Image Image => _image;
}
