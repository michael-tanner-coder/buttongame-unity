using UnityEngine;

[CreateAssetMenu(fileName = "AudioCueSO", menuName = "Audio/AudioCueSO", order = 0)]
public class AudioCueSO : ScriptableObject 
{
    [SerializeField]
    private bool _looping;

    [SerializeField]
    private AudioClip _clip;

    public void Play()
    {

    }
}

