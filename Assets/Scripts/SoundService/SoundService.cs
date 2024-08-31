using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundService : BaseService
{
    [SerializeField] private SoundReferencesSO soundReferences;

    private void Start()
    {
        TestScript.OnAnyExampleSoundEvent += OnExampleSoundEvent;
    }

    private void OnDestroy()
    {
        TestScript.OnAnyExampleSoundEvent -= OnExampleSoundEvent;
    }

    private void OnExampleSoundEvent()
    {
        float volume = 0.5f;
        Play2DSound(soundReferences.exampleAudio, volume);
    }

    private void Play2DSound(AudioClip clip, float volume = 1f)
    {
        PlaySound(clip, Camera.main.transform.transform.position, volume);
    }
    
    private void PlaySound(AudioClip clip, Vector3 position, float volume)
    {
        AudioSource.PlayClipAtPoint(clip, position, volume);
    }
}
