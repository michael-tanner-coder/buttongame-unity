using UnityEngine;

[CreateAssetMenu(fileName = "AudioConfigurationSO", menuName = "Audio/AudioConfigurationSO", order = 0)]
public class AudioConfigurationSO : ScriptableObject 
{
    [SerializeField]
    private AudioSource _source;
    
    [SerializeField]
    private int _priority = 1;
    
    [SerializeField]
    private float _volume = 1;
    
    [SerializeField]
    private float _pitch = 1;

    void SetConfigurations()
    {
        _source.priority = _priority;
        _source.volume = _volume;
        _source.pitch = _pitch;
    }
}
