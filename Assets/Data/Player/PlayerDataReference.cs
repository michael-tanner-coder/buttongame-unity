namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class PlayerDataReference : BaseReference<PlayerData, PlayerDataVariable>
    {
        public PlayerDataReference() : base() { }
        public PlayerDataReference(PlayerData value) : base(value) { }
    } 
}