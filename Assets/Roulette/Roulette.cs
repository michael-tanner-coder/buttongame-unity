using UnityEngine;
using ScriptableObjectArchitecture;
public class Roulette : MonoBehaviour
{
    [Header("Roulette Properties")]
    [SerializeField] private FloatVariable _speed;
    [SerializeField] private int _itemLimit;

    [Header("Roulette Price")]
    [SerializeField] private IntVariable _baseCost;
    [SerializeField] private IntVariable _costModifier;
    [SerializeField] private IntVariable _money;
    [SerializeField] private IntVariable _goal;
    private int _totalCost;

    [Header("Item Lists")]
    [SerializeField] private ItemList _selectedItems;
    [SerializeField] private ItemList _availableItems;
    [SerializeField] private ItemList _rouletteItems;

    [Header("Dependencies")]
    [SerializeField] private Inventory _inventory;
    [SerializeField] private RuleSet _rules;

    void CalculateCost()
    {
        _totalCost = _baseCost.Value + 1000 * (_money.Value/_goal.Value) * _costModifier.Value;
    }
    void Awake()
    {
        _selectedItems.Value.Clear();
        LoadRoulette();
    }

    public void ToggleRoulette()
    {
        if (_speed.Value == 0 && _money.Value >= _baseCost.Value)
        {
            _money.Value -= _totalCost;
            _speed.Value = 240f;
            foreach(ItemSO item in _selectedItems.Value)
            {
                Debug.Log("Discarding " + item.itemName);
                _inventory.Remove(item);
                _rules.ChangeRulesViaItem(item);
            }
            _selectedItems.Value.Clear();
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
            int index = Random.Range(0, _availableItems.Value.Count);
            ItemSO randomItem = _availableItems.Value[index];
            Debug.Log("Adding:");
            Debug.Log(randomItem.itemName);
            _rouletteItems.Value.Add(randomItem);
        }
    }
}
