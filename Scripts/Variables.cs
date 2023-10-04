using UnityEngine;

public class Variables : MonoBehaviour
{
    public static int death;
    public static int totalGems;
    public static int totalKeys;

    public static int totalGemsInLevel;
    public static int collectedGemsInLevel;

    public static int totalKeysInLevel;
    public static int collectedKeysInLevel;

    private void Awake()
    {
        death = PlayerPrefs.GetInt("Deaths");
        totalGems = PlayerPrefs.GetInt("Gems");
        totalKeys = PlayerPrefs.GetInt("Keys");

        totalGemsInLevel = FindObjectsOfType<GemPickup>().Length;
        totalKeysInLevel = FindObjectsOfType<KeyPickup>().Length;
    }
}
