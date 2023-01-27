using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private ItemSO _itemData;
    
    [SerializeField]
    private float _speed;

    void Start() 
    {
        // read item data on start
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = _itemData.sprite;

        gameObject.name = _itemData.name;
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "door") 
        {
            _speed *= -1;
        }
    }
}
