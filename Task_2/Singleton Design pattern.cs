using UnityEngine;

public class SINGLETON<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance;

    private void Awake()
    {
        RegisterSingleton();
    }

    protected void RegisterSingleton()
    {
        Debug.Log("Registering Singleton");

        if (Instance == null)
        {
            Instance = this as T;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
