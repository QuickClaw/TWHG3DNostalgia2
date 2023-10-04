using UnityEngine;
using Steamworks;
using UnityEngine.SceneManagement;

public class SteamAchievements : MonoBehaviour
{
    private void Start()
    {
        #region Level Achievements
        if (SceneManager.GetActiveScene().buildIndex == 6)
        {
            SteamUserStats.SetAchievement("achi_01");
            SteamUserStats.StoreStats();
        }

        if (SceneManager.GetActiveScene().buildIndex == 11)
        {
            SteamUserStats.SetAchievement("achi_02");
            SteamUserStats.StoreStats();
        }

        if (SceneManager.GetActiveScene().buildIndex == 16)
        {
            SteamUserStats.SetAchievement("achi_03");
            SteamUserStats.StoreStats();
        }

        if (SceneManager.GetActiveScene().buildIndex == 21)
        {
            SteamUserStats.SetAchievement("achi_04");
            SteamUserStats.StoreStats();
        }

        if (SceneManager.GetActiveScene().buildIndex == 26)
        {
            SteamUserStats.SetAchievement("achi_05");
            SteamUserStats.StoreStats();
        }

        if (SceneManager.GetActiveScene().buildIndex == 31)
        {
            SteamUserStats.SetAchievement("achi_06");
            SteamUserStats.StoreStats();
        }

        if (SceneManager.GetActiveScene().buildIndex == 36)
        {
            SteamUserStats.SetAchievement("achi_07");
            SteamUserStats.StoreStats();
        }

        if (SceneManager.GetActiveScene().buildIndex == 41)
        {
            SteamUserStats.SetAchievement("achi_08");
            SteamUserStats.StoreStats();
        }

        if (SceneManager.GetActiveScene().buildIndex == 46)
        {
            SteamUserStats.SetAchievement("achi_09");
            SteamUserStats.StoreStats();
        }

        if (SceneManager.GetActiveScene().buildIndex == 51)
        {
            SteamUserStats.SetAchievement("achi_10");
            SteamUserStats.StoreStats();
        }
        #endregion
    }

    private void Update()
    {
        if (!SteamManager.Initialized)
        {
            return;
        }
    }
}