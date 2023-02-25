using UnityEngine;
using TMPro;
using ScriptableObjectArchitecture;
public class UpdateText : MonoBehaviour
{
    [SerializeField] private TMP_Text _label;
    [SerializeField] private string _stringText;
    [SerializeField] private IntVariable _intText;

    void Update()
    {
        _label.text = _stringText + " " + _intText.Value.ToString();
    }
}
