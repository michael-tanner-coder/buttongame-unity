using System.Collections.Generic;
using UnityEngine;

public class DynamicScrollView : MonoBehaviour
{
    [SerializeField] private Transform scrollViewContent;
    [SerializeField] private GameObject prefab;
    [SerializeField] private ItemList _items;
    private List<GameObject> _children = new List<GameObject>();

    private void Start() 
    {
        BuildContent();
    }

    public void RefreshContent()
    {
        
    }

    public void BuildContent()
    {
        foreach(GameObject child in _children)
        {
            Destroy(child);
        }
        _children.Clear();

        foreach(ItemSO itemData in _items.Value)
        {
            GameObject newItem = Instantiate(prefab, scrollViewContent);
            _children.Add(newItem);
            if(newItem.TryGetComponent<ScrollViewItem>(out ScrollViewItem item))
            {
                item.SetData(itemData);
            }
        }
    }
}
