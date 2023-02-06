using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public class PlayerDataEvent : UnityEvent<PlayerData> { }

    [CreateAssetMenu(
        fileName = "PlayerDataVariable.asset",
        menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "PlayerData",
        order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 3)]
    public class PlayerDataVariable : BaseVariable<PlayerData, PlayerDataEvent>
    {
    } 
}