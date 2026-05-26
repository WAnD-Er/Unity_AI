using UnityEngine;

public class Test : Singleton<Test>
{
    private AudioSource audioSource;

    protected override void Awake()
    {
        base.Awake();
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }

    void Start()
    {
        // 可以在这里使用 audioSource，比如播放音频
        // audioSource.Play();
    }

    void Update()
    {
        // audioSource 现在已经缓存，可以在每帧中使用
    }
}
