using UnityEngine;
using ScriptableObjectArchitecture;

public class Item : MonoBehaviour
{
    [SerializeField]
    private ItemSO _itemData;
    public ItemSO Data => _itemData;

    [SerializeField]
    private ItemList _availableItems;
    
    [SerializeField]
    private float _speed;

    [SerializeField]
    private GameObjectCollection _doors;

    [SerializeField]
    private GameRules _rules;

    private float _effectDuration;
    private bool _activated = false;

    void Start() 
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        renderer.sprite = _itemData.sprite;
        gameObject.name = _itemData.name;
        _effectDuration = _itemData.effectDuration;
    }

    void Update() 
    {
        if (_activated)
        {
            _effectDuration -= Time.deltaTime;
        }

        if (_effectDuration <= 0)
        {
            Destroy(gameObject);
            _rules.ResetToDefaults();
        }
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (_doors.Contains(other.gameObject)) 
        {
            _speed *= -1;
        }
    }

    public void ActivateEffect() 
    {
        _activated = true;
    }
}
