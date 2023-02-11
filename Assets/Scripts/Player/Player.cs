using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private PlayerData _data;

    public void Start() 
    {
        SetPlayerData(_data);
    }

    public void SetPlayerType(PlayerType type) 
    {
        _data.SetType(type);
        SetPlayerData(_data);
    }

    public void SetPlayerData(PlayerData data)
    {
        _data = data;
        PlayerType type = _data.Type;
        SpriteRenderer spr = GetComponent<SpriteRenderer>();
        spr.sprite = type.PlayerSprite;
    }
}
