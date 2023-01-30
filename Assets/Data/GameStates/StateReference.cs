namespace ScriptableObjectArchitecture
{
    [System.Serializable]
    public sealed class StateReference : BaseReference<GameState, StateVariable>
    {
        public StateReference() : base() { }
        public StateReference(GameState value) : base(value) { }
    } 
}