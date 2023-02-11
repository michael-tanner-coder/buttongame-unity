using UnityEngine;
using ScriptableObjectArchitecture;

public class GameRules : MonoBehaviour
{
    [SerializeField] private RuleSet _ruleSet;
    [SerializeField] private GameEvent _swapCharacters;
    [SerializeField] private PlayerCharacterSwap _characterSwapper;

    void Awake() 
    {
        ResetToDefaults();
    }

    public void ResetToDefaults()
    {
        _ruleSet.ResetToDefaults();
    }

    public void ChangeRulesViaItem(Item item) 
    {
        _ruleSet.ChangeRulesViaItem(item.Data);

        if (item.Data.swapCharacters)
        {
            _characterSwapper.Swap();
            _swapCharacters.Raise();
        }
    }
}
