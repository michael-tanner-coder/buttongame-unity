using UnityEngine;
using System.Collections.Generic;
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
    [SerializeField] private IntVariable _totalCost;

    [Header("Item Lists")]
    [SerializeField] private ItemList _selectedItems;
    [SerializeField] private ItemList _availableItems;
    [SerializeField] private ItemList _rouletteItems;

    [Header("Dependencies")]
    [SerializeField] private Inventory _inventory;
    [SerializeField] private RuleSet _rules;

    private Dictionary<float, int> _costDictionary = new Dictionary<float, int>();

    void CalculateCost()
    {
        // use cost lookup table to determine by what factor the base cost is multiplied
        InitCostDictionary();
        int costIncreaseFactor = 1;
        float percentageProgress = (float)_money.Value / (float)_goal.Value;
        foreach(float f in _costDictionary.Keys)
        {
            if (percentageProgress >= f)
            {
                costIncreaseFactor = _costDictionary[f];
            }
        }

        // cost formula
        _totalCost.Value = _baseCost.Value * costIncreaseFactor;
    }

    void InitCostDictionary()
    {
        _costDictionary.Clear();
        _costDictionary.Add(0f, 1);
        _costDictionary.Add(0.25f, 2);
        _costDictionary.Add(0.5f, 3);
        _costDictionary.Add(0.75f, 4);
    }

    void Awake()
    {
        _selectedItems.Value.Clear();
        LoadRoulette();
        CalculateCost();
    }

    public void ToggleRoulette()
    {
        if (_speed.Value == 0 && _money.Value >= _baseCost.Value)
        {
            _money.Value -= _totalCost.Value;
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

        CalculateCost();
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
