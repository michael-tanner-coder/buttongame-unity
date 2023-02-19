using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour
{
    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _label;
    [SerializeField] private TMP_Text _count;
    [SerializeField] private InventoryItem _item;

    void Update()
    {
        _label.text = _item.data.itemName;
        _icon.sprite = _item.data.sprite;
        _count.text = _item.stackSize.ToString();
    }

    public void Set(InventoryItem itemReference)
    {
        _item = itemReference;
    }
}
