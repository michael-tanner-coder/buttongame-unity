using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContentList : MonoBehaviour
{
    public List<string> list = new List<string>();
    [SerializeField] private GameObject _listItemPrefab;

    public void InitList(List<string> newList)
    {
        // clear out any existing content
        foreach(Transform child in transform)
        {
            Destroy(child.gameObject);
        }
        
        // spawn a new list of content items
        list = newList;
        foreach(string item in list)
        {
            GameObject newText = Instantiate(_listItemPrefab, transform);
            newText.GetComponent<TMP_Text>().text = item;
        }
    }
}
