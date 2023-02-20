using UnityEngine;
using ScriptableObjectArchitecture;

public class ExchangeItems : MonoBehaviour
{
    [SerializeField] private ItemList _selectedItems;
    [SerializeField] private IntVariable _money;

    public void Exchange()
    {
        foreach(ItemSO item in _selectedItems.Value)
        {
            _money.Value += item.value;
        }
    }

}
