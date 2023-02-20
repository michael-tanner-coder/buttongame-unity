using UnityEngine;
using ScriptableObjectArchitecture;

public class ExchangeItems : MonoBehaviour
{
    [SerializeField] private ItemList _selectedItems;
    [SerializeField] private IntVariable _money;
    [SerializeField] private Inventory _inventorySystem;

    
    public void Awake()
    {
            _selectedItems.Value.Clear();
    }
    public void Exchange()
    {
        foreach(ItemSO item in _selectedItems.Value)
        {
            _money.Value += item.value;
            _inventorySystem.Remove(item);
            _selectedItems.Value.Clear();
        }
    }

}
