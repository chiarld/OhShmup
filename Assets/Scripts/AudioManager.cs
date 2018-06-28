using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class AudioManager
{

    static Dictionary<Audios, AudioClip> audios = new Dictionary<Audios, AudioClip>();
    static AudioSource audioSource;
    static bool initialized = false;

    public static bool Initialized
    {
        get { return initialized; }
    }

    public static void Initialize(AudioSource source)
    {
        initialized = true;
        audioSource = source;
        audios.Add(Audios.ButtonPressed, Resources.Load<AudioClip>(@"Sounds/buttonPressed"));
        audios.Add(Audios.EnemyDied, Resources.Load <AudioClip>(@"Sounds/enemyDied"));
        audios.Add(Audios.PlayerDied, Resources.Load<AudioClip>(@"Sounds/playerDied"));
        audios.Add(Audios.PlayerHit, Resources.Load<AudioClip>(@"Sounds/playerHit"));
        audios.Add(Audios.PlayerShoot, Resources.Load<AudioClip>(@"Sounds/playerShoot"));

    }

    public static void PlayAudio(Audios name)
    {
        audioSource.PlayOneShot(audios[name]);
    }
}
