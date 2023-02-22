using UnityEngine;
using ScriptableObjectArchitecture;
public class Roulette : MonoBehaviour
{
    [Header("Roulette Properties")]
    [SerializeField] private FloatVariable _speed;
    [SerializeField] private IntVariable _money;
    [SerializeField] private IntVariable _cost;
    [SerializeField] private int _itemLimit;

    [Header("Item Lists")]
    [SerializeField] private ItemList _selectedItems;
    [SerializeField] private ItemList _availableItems;
    [SerializeField] private ItemList _rouletteItems;

    [Header("Dependencies")]
    [SerializeField] private Inventory _inventory;
    [SerializeField] private RuleSet _rules;

    void Awake()
    {
        LoadRoulette();
    }

    public void ToggleRoulette()
    {
        if (_speed.Value == 0 && _money.Value >= _cost.Value)
        {
            _money.Value -= _cost.Value;
            _speed.Value = 240f;
            foreach(ItemSO item in _selectedItems.Value)
            {
                Debug.Log("Discarding " + item.itemName);
                _inventory.Remove(item);
                _rules.ChangeRulesViaItem(item);
            }
            // emit event that roulete finished?
        }
        else 
        {
            _speed.Value = 0f;
        }
    }

    public void LoadRoulette()
    {
        _rouletteItems.Value.Clear();
        for (int i = 0; i < _itemLimit; i++)
        {
            // look at item rarity and roll a chance to add the item to the list?
            // go with a naive random element first
            int index = Random.Range(0, _availableItems.Value.Count);
            ItemSO randomItem = _availableItems.Value[index];
            _rouletteItems.Value.Add(randomItem);
        }
    }
}