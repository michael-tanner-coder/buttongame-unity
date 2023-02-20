using UnityEngine;
using ScriptableObjectArchitecture;
public class Roulette : MonoBehaviour
{

    [SerializeField] private FloatVariable _speed;
    [SerializeField] private IntVariable _money;
    [SerializeField] private IntVariable _cost;
    [SerializeField] private ItemList _selectedItems;
    [SerializeField] private ItemList _inventory;
    public void ToggleRoulette()
    {
        if (_speed.Value == 0 && _money.Value >= _cost.Value)
        {
            _money.Value -= _cost.Value;
            _speed.Value = 240f;
            foreach(ItemSO item in _selectedItems.Value)
            {
                Debug.Log("Discarding " + item.itemName);
                _inventory.Value.Remove(item);
            }
            // emit event that roulete finished?
        }
        else 
        {
            _speed.Value = 0f;
        }
    }
}
