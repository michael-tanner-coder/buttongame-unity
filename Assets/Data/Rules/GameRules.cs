using UnityEngine;
using ScriptableObjectArchitecture;

public class GameRules : MonoBehaviour
{
    [SerializeField]
    private FloatVariable _gravityModifier;

    void Awake() 
    {
        ResetToDefaults();
    }


    public void ResetToDefaults()
    {
        _gravityModifier.Value = 1f;
    }

    public void ChangeRulesViaItem(ItemSO item) 
    {
        if (item.gravityModifier != 0f)
        {
            _gravityModifier.Value = item.gravityModifier;
        }
    }
}
