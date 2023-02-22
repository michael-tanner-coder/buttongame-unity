using System.Collections.Generic;
using UnityEngine;

public class DynamicScrollView : MonoBehaviour
{
    [SerializeField] private Transform scrollViewContent;
    [SerializeField] private GameObject prefab;
    [SerializeField] private ItemList _items;

    private void Start() 
    {
        foreach(ItemSO itemData in _items.Value)
        {
            GameObject newItem = Instantiate(prefab, scrollViewContent);
            if(newItem.TryGetComponent<ScrollViewItem>(out ScrollViewItem item))
            {
                item.SetData(itemData);
            }
        }
    }
}
