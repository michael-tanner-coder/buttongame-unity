using System.Collections.Generic;
using UnityEngine;

public class ContentList : MonoBehaviour
{
    public List<string> list = new List<string>();
    [SerializeField] private GameObject _listItemPrefab;

    void Start()
    {
        foreach(string item in list)
        {
            Instantiate(_listItemPrefab);
        }
    }
}
