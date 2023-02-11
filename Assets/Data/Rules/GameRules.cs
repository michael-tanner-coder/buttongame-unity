using UnityEngine;

public class GameRules : MonoBehaviour
{
    [SerializeField]
    private RuleSet _ruleSet;

    void Awake() 
    {
        ResetToDefaults();
    }


    public void ResetToDefaults()
    {
        _ruleSet.ResetToDefaults();
    }

    public void ChangeRulesViaItem(ItemSO item) 
    {
        _ruleSet.ChangeRulesViaItem(item);
    }
}
