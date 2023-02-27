using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class InventorySlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler 
{
    [SerializeField] private Image _icon;
    [SerializeField] private TMP_Text _label;
    [SerializeField] private TMP_Text _count;
    [SerializeField] private TMP_Text _value;
    [SerializeField] private InventoryItem _item;
    [SerializeField] private ItemList _selectedItems;

    void Update()
    {
        _icon.sprite = _item.data.sprite;
        _label.text = _item.data.itemName;
        _count.text = _item.stackSize.ToString();
        _value.text = "Value: " + _item.data.value.ToString();

        if (_selectedItems.Value.Contains(_item.data))
        {
            _icon.color = Color.green;
        }
    }

    public void Set(InventoryItem itemReference)
    {
        _item = itemReference;
    }

    void OnMouseEnter()
    {
        Debug.Log("OnMouseEnter");
        _icon.color = Color.red;
    }
    void OnMouseExit()
    {
        Debug.Log("OnMouseExit");
        _icon.color = Color.white;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("OnMouseEnter");
        _icon.color = Color.red;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("OnMouseExit");
        _icon.color = Color.white;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("OnPointerClick");
        if (!_selectedItems.Value.Contains(_item.data))
        {
            _selectedItems.Value.Add(_item.data);
        }
        else 
        {
            _selectedItems.Value.Remove(_item.data);
        }
    }
}
