using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TutorialContent : MonoBehaviour
{
    [SerializeField] private TutorialPrompt _prompt;
    [SerializeField] private TMP_Text _header;
    [SerializeField] private GameObject _contentBox;
    [SerializeField] private Image _image;

    void Start()
    {
        _header.text = _prompt.Header;
        _image = _prompt.Image;
        _contentBox.GetComponent<ContentList>().InitList(_prompt.Content);
    }
}
