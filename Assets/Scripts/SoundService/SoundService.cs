using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundService : BaseService
{
    [SerializeField] private SoundReferencesSO soundReferences;

    public void PlaySound(AudioClip clip, Vector3 position, float volume)
    {
        AudioSource.PlayClipAtPoint(clip, position, volume);
    }
}
