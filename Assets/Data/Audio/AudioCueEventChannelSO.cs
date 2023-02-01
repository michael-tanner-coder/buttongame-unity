using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "AudioCueEventChannelSO", menuName = "Audio/AudioCueEventChannelSO", order = 0)]
public class AudioCueEventChannelSO : ScriptableObject 
{
    public UnityAction<AudioCueSO, AudioConfigurationSO> OnAudioCueRequested;
    public void RaiseEvent(AudioCueSO audioCue, AudioConfigurationSO audioConfiguration)
    {
        if (OnAudioCueRequested != null)
        {
            OnAudioCueRequested.Invoke(audioCue, audioConfiguration);
        } 
        else 
        {
            Debug.Log("WARNING: you fucked up the audio");
        }
    }    
}