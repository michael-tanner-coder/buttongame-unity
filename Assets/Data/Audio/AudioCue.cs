using UnityEngine;

public class AudioCue : MonoBehaviour
{

    [SerializeField]
    private AudioCueSO _audioCue;
    
    [SerializeField]
    private bool _playOnStart;
    
    [SerializeField]
    private AudioConfigurationSO _audioConfiguration;
    
    [SerializeField]
    private AudioCueEventChannelSO _audioCueEventChannel;

    public void PlayAudioCue() 
    {
        _audioCueEventChannel.RaiseEvent(_audioCue, _audioConfiguration);
    }
}
