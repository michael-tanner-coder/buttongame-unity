using UnityEngine;
[CreateAssetMenu(fileName = "ItemSO", menuName = "Scriptable Objects/Inventory Item", order = 0)]
public class InventoryItem: ScriptableObject
{
    [SerializeField] public ItemSO data;
    public int stackSize;
    public InventoryItem(ItemSO source)
    {
        data = source;
        AddToStack();
    }

    public void AddToStack()
    {
        stackSize++;
    }

    public void RemoveFromStack()
    {
        stackSize--;
    }
}
