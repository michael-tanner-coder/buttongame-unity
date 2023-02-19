using UnityEngine;
public class MoveScrollContent : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = 1f;
    [SerializeField] private bool _loop;
    [SerializeField] private RectTransform _viewPortRect;
    [SerializeField] private RectTransform _contentRect;

    void Update()
    {
        float currentX = _contentRect.anchoredPosition.x;
        float newX = currentX + _scrollSpeed * Time.deltaTime;
        _contentRect.anchoredPosition = new Vector2(newX, _contentRect.anchoredPosition.y);

        if (_loop) {
            if (newX >= _viewPortRect.anchoredPosition.x + _viewPortRect.rect.width) {
                float leftBoundary = _viewPortRect.anchoredPosition.x - _contentRect.rect.width/2;
                _contentRect.anchoredPosition = new Vector2(leftBoundary, _contentRect.anchoredPosition.y);
            }
        }
    }
}
