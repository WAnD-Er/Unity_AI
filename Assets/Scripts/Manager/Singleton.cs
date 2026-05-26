using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                if (_instance == null)
                {
                    Debug.LogWarning($"[Singleton<{typeof(T).Name}>] No instance found in scene.");
                }
            }
            return _instance;
        }
    }

    protected virtual void Awake()
    {
        if (_instance == null)
        {
            _instance = this as T;
            return;
        }

        if (_instance != this)
        {
            Debug.LogWarning($"[Singleton<{typeof(T).Name}>] Instance already exists, destroying duplicate on '{gameObject.name}'.");
            Destroy(gameObject);
        }
    }
}
