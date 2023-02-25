using UnityEngine;

public class DiscardItems : MonoBehaviour
{
    [SerializeField] private ItemList _selectedItems;
    [SerializeField] private Inventory _inventory;
    [SerializeField] private RuleSet _rules;
    public void ActivateItemEffects()
    {
        foreach(ItemSO item in _selectedItems.Value)
        {
            _inventory.Remove(item);
            _rules.ChangeRulesViaItem(item);
        }
        _selectedItems.Value.Clear();
    }
}
