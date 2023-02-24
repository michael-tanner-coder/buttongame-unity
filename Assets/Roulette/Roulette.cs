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
    
    [Header("Item Drop Rates")]
    private Dictionary<ItemSO, ItemDrop> _itemDropTable = new Dictionary<ItemSO, ItemDrop>();
    private float _probabilityTotalWeight;
    [SerializeField] private ItemDropTable _dropTable;

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
        InitCostDictionary();
        // InitItemDropTable();
        LoadRoulette();
        CalculateCost();
    }

    void PayForSpin()
    {
        if (!_rules.RetrySpin.Value)
        {
            _money.Value -= _totalCost.Value;
            _rules.RetrySpin.Value = false;
        }
    }

    public void ToggleRoulette()
    {
        if (_speed.Value == 0 && _money.Value >= _baseCost.Value)
        {
            PayForSpin();
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
        Debug.Log("_probabilityTotalWeight");
        Debug.Log(_probabilityTotalWeight);
        for (int i = 0; i < _itemLimit; i++)
        {
            float pickedNumber = Random.Range(0, _probabilityTotalWeight);

            // 
            foreach(ItemSO item in _availableItems.Value)
            {
                if (pickedNumber > _dropTable.Lookup[item].probabilityFrom && pickedNumber < _dropTable.Lookup[item].probabilityTo)
                {
                    Debug.Log("Picked " + item.itemName);
                    _rouletteItems.Value.Add(item);
                }
            }

            // 
            // foreach(ItemSO item in _itemDropTable.Keys)
            // {
            //     if (pickedNumber > _itemDropTable[item].probabilityFrom && pickedNumber < _itemDropTable[item].probabilityTo)
            //     {
            //         Debug.Log("Picked " + item.itemName);
            //         _rouletteItems.Value.Add(item);
            //     }
            // }

            // if no item was picked, just add a default item
            if (_rouletteItems.Value.Count < i + 1)
            {
                _rouletteItems.Value.Add(_availableItems.Value[0]);
            }
        }
    }


    // TODO: test distrubutions of probability table
    // TODO: make sure it can't go over the item limit
    // TODO: test backup default items
    // TODO: abstract drop table outside of roulette
    void InitItemDropTable()
    {
        float currentProbabilityWeightMaximum = 0f;
        foreach(ItemSO item in _availableItems.Value)
        {
            ItemDrop itemDropEntry = new ItemDrop();
            if (item.rarity < 0f)
            {
                Debug.Log("Can't have a negative probability weight");
                itemDropEntry.probabilityWeight = 0f;
            }
            else 
            {
                itemDropEntry.probabilityWeight = item.rarity;
                itemDropEntry.probabilityFrom = currentProbabilityWeightMaximum;
                currentProbabilityWeightMaximum += itemDropEntry.probabilityWeight;	
                itemDropEntry.probabilityTo = currentProbabilityWeightMaximum;
            }
            _itemDropTable.Add(item, itemDropEntry);
        }
        _probabilityTotalWeight = currentProbabilityWeightMaximum;
    }
}
