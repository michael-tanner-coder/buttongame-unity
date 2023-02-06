using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public class GameModeEvent : UnityEvent<GameMode> { }

    [CreateAssetMenu(
        fileName = "GameModeVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "GameMode",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 3)]
    public class GameModeVariable : BaseVariable<GameMode, GameModeEvent>
    {
    } 
}