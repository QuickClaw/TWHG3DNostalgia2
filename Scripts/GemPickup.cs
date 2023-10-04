using UnityEngine;
using Steamworks;
using TMPro;

public class GemPickup : MonoBehaviour
{
    public Variables Variables;
    public Obstacle Obstacle;
    public Texts Texts;

    public TMP_Text txtGems;

    public ParticleSystem gemEffect;

    public AudioSource gemAudioSource;
    public AudioClip[] shoot;
    private AudioClip shootClip;

    public bool gemTaken;
    public Vector3 posGem;

    void Start()
    {
        posGem = transform.position;

        Texts.txtGems.text = "Gems: " + Variables.collectedGemsInLevel.ToString() + "/" + Variables.totalGemsInLevel.ToString();
    }

    private void Update()
    {
        transform.Rotate(0, 0.1f, 0 * Time.deltaTime);

        if (Obstacle.isDead)
        {
            ResetGemLocation();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag is "Player")
        {
            gemTaken = true;
            transform.position = new Vector3(0, 5000, 0);

            Variables.totalGems++;
            PlayerPrefs.SetInt("Gems", Variables.totalGems);

            Variables.collectedGemsInLevel++;

            Texts.txtGems.text = "Gems: " + Variables.collectedGemsInLevel.ToString() + "/" + Variables.totalGemsInLevel.ToString();

            gemEffect.Play();

            int index = Random.Range(0, shoot.Length);
            shootClip = shoot[index];
            gemAudioSource.clip = shootClip;
            gemAudioSource.Play();

            #region Gem Achievements
            if (Variables.totalGems == 10)
            {
                SteamUserStats.SetAchievement("achi_11");
                SteamUserStats.StoreStats();
            }

            if (Variables.totalGems == 20)
            {
                SteamUserStats.SetAchievement("achi_12");
                SteamUserStats.StoreStats();
            }

            if (Variables.totalGems == 50)
            {
                SteamUserStats.SetAchievement("achi_13");
                SteamUserStats.StoreStats();
            }

            if (Variables.totalGems == 100)
            {
                SteamUserStats.SetAchievement("achi_14");
                SteamUserStats.StoreStats();
            }

            if (Variables.totalGems == 300)
            {
                SteamUserStats.SetAchievement("achi_15");
                SteamUserStats.StoreStats();
            }

            if (Variables.totalGems == 500)
            {
                SteamUserStats.SetAchievement("achi_16");
                SteamUserStats.StoreStats();
            }

            if (Variables.totalGems == 1000)
            {
                SteamUserStats.SetAchievement("achi_17");
                SteamUserStats.StoreStats();
            }

            if (Variables.totalGems == 5000)
            {
                SteamUserStats.SetAchievement("achi_18");
                SteamUserStats.StoreStats();
            }

            if (Variables.totalGems == 10000)
            {
                SteamUserStats.SetAchievement("achi_19");
                SteamUserStats.StoreStats();
            }
            #endregion
        }
    }

    void ResetGemLocation()
    {
        transform.position = posGem;
    }
}