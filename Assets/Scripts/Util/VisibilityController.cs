using UnityEngine;

public class VisibilityController : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    public void ToggleVisibility()
    {
        _spriteRenderer.enabled = _spriteRenderer.enabled ? false : true;
    }
    public void SetVisibility(bool isVisible)
    {
        _spriteRenderer.enabled = isVisible;
    }
}
