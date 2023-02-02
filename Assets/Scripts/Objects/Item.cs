using UnityEngine;
using ScriptableObjectArchitecture;

public class Item : MonoBehaviour
{
    [SerializeField]
    private ItemSO _itemData;

    [SerializeField]
    private ItemList _availableItems;
    
    [SerializeField]
    private float _speed;

    [SerializeField]
    private GameObjectCollection _doors;

    public void PickItemType() 
    {
        int index = Random.Range(0, _availableItems.Value.Count);
        _itemData = _availableItems.Value[index];
    }

    void Start() 
    {
        // randomly pick an item to be on start
        PickItemType();
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = _itemData.sprite;
        gameObject.name = _itemData.name;
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (_doors.Contains(other.gameObject)) 
        {
            _speed *= -1;
        }
    }
}
