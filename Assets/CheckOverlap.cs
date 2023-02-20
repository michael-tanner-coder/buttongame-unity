using UnityEngine;
using UnityEngine.UI;

public class CheckOverlap : MonoBehaviour
{
    [SerializeField] private Image _image;
    private bool highlighted = false;
    [SerializeField] private Collider2D _collider;
    [SerializeField] private Collider2D _otherCollider;
    [SerializeField] private ItemList _inventoryList;
    [SerializeField] private ScrollViewItem _scrollViewItem;

    void Awake()
    {
        GameObject hitbox = GameObject.Find("Hitbox");
        _otherCollider = hitbox.GetComponent<Collider2D>();
    }

    public void AddSelfToInventory()
    {
        if (highlighted)
        {
            _inventoryList.Value.Add(_scrollViewItem.Data);
        }
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
