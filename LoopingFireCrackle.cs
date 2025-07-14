using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class LoopingFireCrackle : MonoBehaviour
{
    [SerializeField] AudioClip fireCrackle;

    void Start()
    {
        AudioSource audioSrc = GetComponent<AudioSource>();
        audioSrc.clip = fireCrackle;
        audioSrc.loop = true;
        audioSrc.playOnAwake = false;
        audioSrc.Play();
    }
}
