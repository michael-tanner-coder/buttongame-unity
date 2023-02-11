using UnityEngine;

[CreateAssetMenu(fileName = "PlayerType", menuName = "Scriptable Objects/PlayerType", order = 0)]
public class PlayerType : ScriptableObject 
{
    [SerializeField] private string _name;
    public string Name => _name;
    [SerializeField] private Sprite _sprite;
    public Sprite PlayerSprite => _sprite;
    [SerializeField] private float _mass;
    public float Mass => _mass;
    [SerializeField] private int _jumpCount;
    public int JumpCount => _jumpCount;
}
