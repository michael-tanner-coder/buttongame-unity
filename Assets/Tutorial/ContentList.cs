using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContentList : MonoBehaviour
{
    public List<string> list = new List<string>();
    [SerializeField] private GameObject _listItemPrefab;

    public void InitList(List<string> newList)
    {
        list = newList;
        foreach(string item in list)
        {
            GameObject newText = Instantiate(_listItemPrefab, transform);
            newText.GetComponent<TMP_Text>().text = item;
        }
    }
}
