using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private ItemSO _itemData;

    void Start() 
    {
        // read item data on start
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = _itemData.sprite;

        gameObject.name = _itemData.name;
    }
}
