using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class KeyPickup : MonoBehaviour
{
    public Variables Variables;
    public Obstacle Obstacle;
    public Texts Texts;
    public CheckPoint CheckPoint;

    public TMP_Text txtKeys;

    public ParticleSystem keyEffect;

    public AudioSource keyAudioSource;

    public GameObject door;
    int sceneIndex;

    public bool keyTaken;

    public Vector3 posKey;

    private void Awake()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    void Start()
    {
        keyTaken = false;
        posKey = transform.position;

        Texts.txtKeys.text = "Keys: " + Variables.collectedKeysInLevel.ToString() + "/" + Variables.totalKeysInLevel.ToString();
    }

    void Update()
    {
        transform.Rotate(0, 0.1f, 0 * Time.deltaTime);

        if (Obstacle.isDead && keyTaken)
        {
            if (CheckPoint.checkPointed == false)
            {
                ResetKeyLocation();

                door.GetComponent<BoxCollider>().enabled = true;
                door.GetComponent<Animation>().Play(gameObject.name + "close-" + sceneIndex.ToString());

                keyTaken = false;
            }
            else
            {
                door.GetComponent<BoxCollider>().enabled = false;
                door.GetComponent<Animation>().Play(gameObject.name + "open-" + sceneIndex.ToString());
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag is "Player")
        {
            keyTaken = true;
            transform.position = new Vector3(0, 5000, 0);

            Variables.totalKeys++;
            PlayerPrefs.SetInt("Keys", Variables.totalKeys);

            Variables.collectedKeysInLevel++;

            Texts.txtKeys.text = "Keys: " + Variables.collectedKeysInLevel.ToString() + "/" + Variables.totalKeysInLevel.ToString();

            door.GetComponent<Animation>().Play(gameObject.name + "open-" + sceneIndex.ToString());

            Invoke(nameof(OpenDoor), 1);

            keyEffect.Play();
            keyAudioSource.Play();
        }
    }

    void ResetKeyLocation()
    {
        transform.position = posKey;
    }

    void OpenDoor()
    {
        door.GetComponent<BoxCollider>().enabled = false;
    }
}