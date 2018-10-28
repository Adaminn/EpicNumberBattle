using UnityEditor;
using UnityEngine;

public class Variables : MonoBehaviour {

    //Data for undestructable objects in scene
    public const string sharedDataObjectName = "SharedData";
    public const string connectionObjectName = "Connection";
    public static GameObject sharedDataObject = Resources.Load<GameObject>(sharedDataObjectName);
    public static GameObject connectionObject = Resources.Load<GameObject>(connectionObjectName);

    // The port number for the remote device.  
    public const int PORT = 11000;
    // public DNS adress for server
    public const string DNS_ADRESS = "LAPTOP-78BRNG9E";
}
