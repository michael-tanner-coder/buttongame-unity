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
    [SerializeField] private FloatIntDictionarySO _costDictionary;
    private bool _freeSpin;

    [Header("Item Lists")]
    [SerializeField] private ItemList _selectedItems;
    [SerializeField] private ItemList _availableItems;
    [SerializeField] private ItemList _rouletteItems;

    [Header("Dependencies")]
    [SerializeField] private Inventory _inventory;
    [SerializeField] private RuleSet _rules;
    
    [Header("Item Drop Rates")]
    private Dictionary<ItemSO, ItemDrop> _itemDropTable = new Dictionary<ItemSO, ItemDrop>();
    private float _probabilityTotalWeight;
    [SerializeField] private ItemDropTable _dropTable;

    void Awake()
    {
        _selectedItems.Value.Clear();
        LoadRoulette();
        CalculateCost();
    }

    void CalculateCost()
    {
        // use cost lookup table to determine by what factor the base cost is multiplied
        int costIncreaseFactor = 1;
        float percentageProgress = (float)_money.Value / (float)_goal.Value;
        foreach(float f in _costDictionary.Value.Keys)
        {
            if (percentageProgress >= f)
            {
                costIncreaseFactor = _costDictionary.Value[f];
            }
        }

        // cost formula
        _totalCost.Value = _baseCost.Value * costIncreaseFactor;
    }

    void PayForSpin()
    {
        if (!_freeSpin)
        {
            _money.Value -= _totalCost.Value;
        }
    }

    public void ToggleRoulette()
    {
        if (_speed.Value == 0 && _money.Value >= _baseCost.Value || _rules.RetrySpin.Value)
        {
            PayForSpin();
            _speed.Value = 240f;
            _freeSpin = _rules.RetrySpin.Value;
            _rules.RetrySpin.Value = false;
        }
        else 
        {
            _speed.Value = 0f;
            if (!_freeSpin)
            {
                _rules.ResetToDefaults();
            }
        }

        CalculateCost();
    }

    public void LoadRoulette()
    {
        _rouletteItems.Value.Clear();
        for (int i = 0; i < _itemLimit; i++)
        {
            float pickedNumber = Random.Range(0, _probabilityTotalWeight);

            foreach(ItemSO item in _availableItems.Value)
            {
                if (pickedNumber > _dropTable.Lookup[item].probabilityFrom && pickedNumber < _dropTable.Lookup[item].probabilityTo)
                {
                    _rouletteItems.Value.Add(item);
                }
            }

            // if no item was picked, just add a default item
            if (_rouletteItems.Value.Count < i + 1)
            {
                _rouletteItems.Value.Add(_availableItems.Value[0]);
            }
        }
    }
}
