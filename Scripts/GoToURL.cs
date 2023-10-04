using UnityEngine;
using UnityEngine.EventSystems;

public class GoToURL : MonoBehaviour, IPointerClickHandler
{
    public string URL;

    public void OnPointerClick(PointerEventData eventData)
    {
        Application.OpenURL(URL);
    }
}
