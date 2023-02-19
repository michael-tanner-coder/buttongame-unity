using UnityEngine;

public class InventoryGrid : MonoBehaviour
{
    [SerializeField] private InventorySystem _inventorySystem;
    [SerializeField] private GameObject _slotPrefab;
    void Start()
    {
        foreach(InventoryItem item in _inventorySystem.inventory)
        {
            GameObject newItem = Instantiate(_slotPrefab, transform);
            if(newItem.TryGetComponent<InventorySlot>(out InventorySlot slot))
            {
                slot.Set(item);
            }
        }
    }
}
