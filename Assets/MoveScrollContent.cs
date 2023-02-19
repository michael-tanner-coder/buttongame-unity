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
        // float currentX = transform.position.x;
        // float newX = currentX + _scrollSpeed * Time.deltaTime;
        // transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        if (_loop) {
            Rect newRect = RectTransformToScreenSpace(_contentRect);
            Vector2 point = new Vector2(_contentRect.position.x, _contentRect.position.y) - new Vector2(Screen.width/2, Screen.height/2);
            if (RectTransformUtility.RectangleContainsScreenPoint(_viewPortRect, new Vector2(transform.position.x, transform.position.y), _camera))
            {
                Debug.Log("Inside viewport!");
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
