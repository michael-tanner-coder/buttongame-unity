using UnityEngine;
using UnityEngine.UI;

public class CheckOverlap : MonoBehaviour
{
    [SerializeField] private Image _image;
    private bool highlighted = false;
    [SerializeField] private Collider2D _collider;
    [SerializeField] private Collider2D _otherCollider;

    void Awake()
    {
        GameObject hitbox = GameObject.Find("Hitbox");
        _otherCollider = hitbox.GetComponent<Collider2D>();
    }

    void Update()
    {
        highlighted = _otherCollider.bounds.Intersects(_collider.bounds);
        if (highlighted)
         {
            _image.color = Color.red;
         }
         else 
         {
            _image.color = Color.white;
         }
    }
}
