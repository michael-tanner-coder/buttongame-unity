using UnityEngine;

public class PlayerCharacterSwap : MonoBehaviour
{
    [SerializeField] private PlayerData _player1;
    [SerializeField] private PlayerData _player2;

    public void Swap()
    {
        PlayerType tempType = _player1.Type;
        _player1.SetType(_player2.Type);
        _player2.SetType(tempType);
    }
}
