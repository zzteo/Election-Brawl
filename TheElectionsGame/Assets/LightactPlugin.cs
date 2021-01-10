using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using UnityEngine;

public class LightactPlugin : MonoBehaviour
{
    private const int LOG_ERROR = 0;
    private const int LOG_WARNING = 1;
    private const int LOG_INFO = 2;
    private const int LOG_DEBUG = 3;

    //values coming from LightAct and then shared with GameObjects
    public static float valRotation;
    public static string valText;

    //values to be sent to LightAct
    public static float float2LA = 0.0f;
    public static string string2LA = "";

    [DllImport("LightactPlugin")]
    static extern void RegisterBuildMapDataCS(BuildMapDataCS cb);
    //Create string param callback delegate
    delegate void BuildMapDataCS(string key, string values);

    delegate void LogCS(string a_log, int a_logLevel);
    [DllImport("LightactPlugin")]
    static extern void RegisterLogCS(LogCS cb);


    [DllImport("LightactPlugin")]
    static extern bool BuildMap(string HandleName, int HandleSize);

    [DllImport("LightactPlugin")] // Open Shared memory
    static extern bool createMemHandle(string HandleName, int HandleSize);

    [DllImport("LightactPlugin")]
    static extern bool writeSharedMemory(string stringMapKey, string stringMapValue, string HandleName, int HandleSize);

    [DllImport("LightactPlugin")]
    static extern bool closeMemHandle(string HandleName);

    [DllImport("LightactPlugin")]
    static extern int lightactProcessTick(int Heartbeat);

    Dictionary<string, string> m_buildMapDictionaryResult;
    public string m_memoryWritingHandle = "vars2LA";
    public string m_memoryReadingHandle = "vars2UE";
    public int m_memorySize = 1024;

    float m_alphaValue = 0f;
    string testString = "hello from Unity";

    void BuildMapData(string keys, string values)
    {
        Debug.Log("Incoming Keys: " + keys);
        Debug.Log("Incoming Values: " + values);

        // let's do some string splitting
        String[] keysArray = keys.Split(','); // comma is our delimiter.
        String[] valuesArray = values.Split(',');
        // you can then transform these values into proper formats (ints, floats etc.) and use them elsewhere in your project.

        float v = 0;

        if (valuesArray.Length > 0 && float.TryParse(valuesArray[0], out v))
        {
            valRotation = v;
        }
        if (valuesArray.Length > 1)
        {
            valText = valuesArray[1];
        }

    }

    void Log(string a_log, int a_logLevel)
    {
        if (a_log.Equals(String.Empty))
            return;
        switch (a_logLevel)
        {
            case LOG_ERROR:
                Debug.LogError(a_log);
                break;
            case LOG_WARNING:
                Debug.LogWarning(a_log);
                break;
            default:
                Debug.Log(a_log);
                break;
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        RegisterBuildMapDataCS(BuildMapData);
        RegisterLogCS(Log);
        Debug.Log("Starting");
        if (createMemHandle(m_memoryWritingHandle, m_memorySize))
        {
            Debug.Log("Opened Shared Memory Write Handle");
        }
        else
        {
            Debug.Log("Error in opening Memory write Handle");
        }
        if (createMemHandle(m_memoryReadingHandle, m_memorySize))
        {
            Debug.Log("Opened Shared Memory Read Handle");
        }
        else
        {
            Debug.Log("Error in opening Memory Read Handle");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Writing to shared memory. You can change the handle name and size in Unity editor
        if (writeSharedMemory("sphereHeight,sphereText", float2LA.ToString("F", CultureInfo.InvariantCulture) + "," + string2LA, m_memoryWritingHandle, m_memorySize))
        {
        }
        else
        {
            Debug.Log("Shared memory Writing failed");
        }

        //Reading from shared memory
        if (BuildMap(m_memoryReadingHandle, m_memorySize))
        {
            //Debug.Log("Reading from shared memory (handle name: "+ m_memoryReadingHandle+") succesful");
        }
        else
            Debug.Log("Reading from shared memory (handle name: " + m_memoryReadingHandle + ") failed");

    }
    void OnDestroy()
    {
        if (closeMemHandle(m_memoryWritingHandle))
        {
            Debug.Log("Closed Shared Memory Write Handle");
        }
        else
        {
            Debug.Log("Error in Closing Memory Write Handle");
        }

        if (closeMemHandle(m_memoryReadingHandle))
        {
            Debug.Log("Closed Shared Memory Read Handle");
        }
        else
        {
            Debug.Log("Error in Closing Memory Read Handle");
        }
        Debug.Log("Destroy");
    }
}
