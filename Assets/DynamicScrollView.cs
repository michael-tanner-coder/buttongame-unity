using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DynamicScrollView : MonoBehaviour
{
    [SerializeField] private Transform scrollViewContent;
    [SerializeField] private GameObject prefab;

    [SerializeField] private List<Sprite> items;

    private void Start() 
    {
        foreach(Sprite itemSprite in items)
        {
            GameObject newItem = Instantiate(prefab, scrollViewContent);
            if(newItem.TryGetComponent<ScrollViewItem>(out ScrollViewItem item))
            {
                item.ChangeImage(itemSprite);
            }
        }
    }
}
