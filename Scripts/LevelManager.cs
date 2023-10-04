using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public Button[] LevelButtons;
    public RawImage[] LockImages;
    public TMP_Text[] ButtonTexts;

    private void Start()
    {
        int saveIndex = PlayerPrefs.GetInt("saveIndex");

        for (int i = 0; i < LevelButtons.Length; i++)
        {
            if (i <= saveIndex)
            {
                LevelButtons[i].interactable = true;
                //LockImages[i].enabled = false;
                LevelButtons[i].GetComponent<Image>().raycastTarget = true;
                ButtonTexts[i].color = Color.green;
            }
            else
            {
                LevelButtons[i].interactable = false;
                //LockImages[i].enabled = true;
                LevelButtons[i].GetComponent<Image>().raycastTarget = false;
                ButtonTexts[i].color = Color.gray;
            }
        }
    }
}