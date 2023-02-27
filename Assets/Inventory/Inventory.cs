using System.Collections.Generic;
using UnityEngine;
using ScriptableObjectArchitecture;

[CreateAssetMenu(fileName = "Inventory", menuName = "buttongame-unity/Inventory", order = 0)]
public class Inventory : ScriptableObject {
    private Dictionary<ItemSO, InventoryItem> _itemDictionary; // lookup table for items that exist in inventory
    public List<InventoryItem> inventory { get; private set; } // wrapper raw item data + quantities
    [SerializeField] private List<ItemSO> _itemDataList; // raw data for each item
    [SerializeField] public IntVariable _inventoryLimit; // how many slots are available in the inventory

    // init
    public void OnEnable()
    {
        _itemDictionary = new Dictionary<ItemSO, InventoryItem>();
        inventory = new List<InventoryItem>();

        foreach(ItemSO item in _itemDataList)
        {
            AddToInventory(item);
        }
    }

    // used in both init and on every item addition
    void AddToInventory(ItemSO referenceData)
    {
        if (_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.AddToStack();
        }
        else
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventory.Add(newItem);
            _itemDictionary.Add(referenceData, newItem);
        }
    } 
    
    // public setters
    public void Add(ItemSO referenceData)
    {
        _itemDataList.Add(referenceData);
         AddToInventory(referenceData);
    }

    public void Remove(ItemSO referenceData)
    {
        if (_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.RemoveFromStack();
            _itemDataList.Remove(referenceData);

            if (value.stackSize == 0)
            {
                inventory.Remove(value);
                _itemDictionary.Remove(referenceData);
            }
        }
    }

    public void Empty()
    {
        _itemDataList.Clear();
        inventory.Clear();
        _itemDictionary.Clear();
    }
}