using UnityEngine;

public class InventoryGrid : MonoBehaviour
{
    [SerializeField] private Inventory _inventorySystem;
    [SerializeField] private GameObject _slotPrefab;
    
    public void BuildGrid()
    {
        foreach(RectTransform child in transform)
        {
            Destroy(child);
        }

        foreach(InventoryItem item in _inventorySystem.inventory)
        {
            GameObject newItem = Instantiate(_slotPrefab, transform);
            if(newItem.TryGetComponent<InventorySlot>(out InventorySlot slot))
            {
                slot.Set(item);
            }
        }
    }
    void Start()
    {
        BuildGrid();
    }



}
