using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    private Dictionary<ItemSO, InventoryItem> m_itemDictionary;
    [SerializeField] private ItemList _dataList;
    [SerializeField] private ItemList _selectedItems;
    [SerializeField] public List<InventoryItem> inventory { get; private set; }

    private void Awake()
    {
        inventory = new List<InventoryItem>();
        m_itemDictionary = new Dictionary<ItemSO, InventoryItem>();
        foreach(ItemSO item in _dataList.Value)
        {
            Add(item);
        }
    }

    public void Add(ItemSO referenceData)
    {
        if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.AddToStack();
        }
        else
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventory.Add(newItem);
            m_itemDictionary.Add(referenceData, newItem);
        } 
    }

    public void Remove(ItemSO referenceData)
    {
        if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.RemoveFromStack();

            if (value.stackSize == 0)
            {
                inventory.Remove(value);
                m_itemDictionary.Remove(referenceData);
            }
        }
    }
}
