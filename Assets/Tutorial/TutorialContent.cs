using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections.Generic;

public class TutorialContent : MonoBehaviour
{
    [SerializeField] private List<TutorialPrompt> _prompts = new List<TutorialPrompt>();
    private int _index = 0;
    [SerializeField] private TMP_Text _header;
    [SerializeField] private GameObject _contentBox;
    [SerializeField] private Image _image;

    void Start()
    {
        UpdatePrompt();
    }
    public void UpdatePrompt()
    {
        _header.text = _prompts[_index].Header;
        _image = _prompts[_index].Image;
        _contentBox.GetComponent<ContentList>().InitList(_prompts[_index].Content);
    }

    public void NextPrompt()
    {
        _index++;
        if (_index >= _prompts.Count)
        {
            _index = _prompts.Count - 1;
        }
        UpdatePrompt();
    }

    public void PreviousPrompt()
    {
        _index--;
        if (_index <= 0)
        {
            _index = 0;
        }
        UpdatePrompt();
    }
}
