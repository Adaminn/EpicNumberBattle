using UnityEngine;

public class SharedData : MonoBehaviour {
    public const string DEFAULT_NAME = "anonym";

    // Data persisted between scene
    public string username = DEFAULT_NAME;
    public string points;

    // Make global
    public static SharedData Data
    {
        get;
        set;
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        Data = this;
    }
}
