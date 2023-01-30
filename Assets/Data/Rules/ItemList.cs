using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "ItemList", menuName = "Scriptable Objects/ItemList", order = 0)]
public class ItemList : ScriptableObject 
{
    [SerializeField]
    private List<ItemSO> _value;
    
    [HideInInspector]
    public List<ItemSO> Value => _value;
}
