using UnityEngine;

public class Progressive : MonoBehaviour {
    static private bool key1 = false;
    static private bool key2 = false;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public bool Entry()
    {
        Debug.Log("Key1 Value: " + key1);
        Debug.Log("Key2 Value: " + key2);
        if (key1 && key2)
        {
            Debug.Log("Entry granted");
            return true;
        }
        else
        {
            if (key1)
            {
                Debug.Log("Twould appear you need the second key");
            }
            else if(key2)
            {
                Debug.Log("Go get the first key!");
            }
            else if(key1 == false && key2 == false)
            {
                Debug.Log("Huh? You don't have any keys...");
            }
            return false;
        }
    }

    public void GetFirstKey()
    {
        key1 = true;
        Debug.Log("Key1 Value: " + key1);
    }

    public void GetSecondKey()
    {
        key2 = true;
        Debug.Log("Key2 Value: " + key2);
    }
}
