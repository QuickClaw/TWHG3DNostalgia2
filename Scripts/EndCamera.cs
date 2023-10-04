using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndCamera : MonoBehaviour
{
    public Camera mainCam, birdsEyeCam;
    public TMP_Text txtDeaths;
    void Start()
    {
        mainCam.enabled = false;
        birdsEyeCam.enabled = true;
        txtDeaths.text = "Deaths: " + Variables.death.ToString();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}
