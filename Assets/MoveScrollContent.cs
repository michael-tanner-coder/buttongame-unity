using UnityEngine;
public class MoveScrollContent : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = 1f;
    [SerializeField] private bool _loop;
    [SerializeField] private RectTransform _viewPortRect;
    [SerializeField] private RectTransform _contentRect;
    [SerializeField] private Camera _camera;

    void Update()
    {
        float currentX = _contentRect.anchoredPosition.x;
        float newX = currentX + _scrollSpeed * Time.deltaTime;
        // transform.position = new Vector3(newX, transform.position.y, transform.position.z);
        // _contentRect.rect.Set(newX, _contentRect.rect.y, _contentRect.rect.width, _contentRect.rect.height);
        _contentRect.anchoredPosition = new Vector2(newX, _contentRect.anchoredPosition.y);

        if (_loop) {
            if (newX >= _viewPortRect.anchoredPosition.x + _viewPortRect.rect.width) {
                float leftBoundary = _viewPortRect.anchoredPosition.x - _contentRect.rect.width/2;
                _contentRect.anchoredPosition = new Vector2(leftBoundary, _contentRect.anchoredPosition.y);
            }
        }
    }

     public static Rect RectTransformToScreenSpace(RectTransform transform)
     {
         Vector2 size = Vector2.Scale(transform.rect.size, transform.lossyScale);
         return new Rect((Vector2)transform.position - (size * transform.pivot), size);
     }

    bool IsPointInRect(Vector2 point, RectTransform rt)
    {
        Rect rect = rt.rect;

        // Get the left, right, top, and bottom boundaries of the rect
        float leftSide = rt.anchoredPosition.x - rect.width / 2;
        float rightSide = rt.anchoredPosition.x + rect.width / 2;
        float topSide = rt.anchoredPosition.y + rect.height / 2;
        float bottomSide = rt.anchoredPosition.y - rect.height / 2;

        // Debug.Log(leftSide + ", " + rightSide + ", " + topSide + ", " + bottomSide);

        // Check to see if the point is in the calculated bounds
        if (point.x >= leftSide &&
            point.x <= rightSide &&
            point.y >= bottomSide &&
            point.y <= topSide)
        {
            return true;
        }
        return false;
    }
}
