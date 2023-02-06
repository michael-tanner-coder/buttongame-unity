using UnityEngine;
using ScriptableObjectArchitecture;

public class WinnerText : MonoBehaviour
{
    [SerializeField]
    private PlayerDataVariable _winner;

    [SerializeField]
    private PlayerData _expectedWinner;

    private SpriteRenderer _spr;

    void Awake()
    {
        _spr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        _spr.enabled = _winner.Value == _expectedWinner;
    }
}
