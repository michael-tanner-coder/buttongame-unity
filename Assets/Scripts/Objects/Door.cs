using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    private DoorState _state;

    [SerializeField]
    private PlayerData _playerData;

    private SpriteRenderer _spriteRenderer;
    private BoxCollider2D _collider;

    void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _collider = GetComponent<BoxCollider2D>();
    }

    public void Activate() 
    {
        _state = _state == DoorState.CLOSED ? DoorState.OPEN : DoorState.CLOSED;
        // _spriteRenderer.enabled = _state == DoorState.CLOSED;
        _playerData.doorState = _state;
    }

    void Update()
    {
        // change target height of sprite and box collider based on door state
        float targetHeight = _state == DoorState.CLOSED ? 0.56f : 0f;
        // 
        _spriteRenderer.size = new Vector2(0.05f, targetHeight);
        _collider.size = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y);

    }
}
