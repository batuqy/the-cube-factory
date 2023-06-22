using UnityEngine;
using UnityEngine.EventSystems;

public class HoverHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject scrollView;

    public void OnPointerEnter(PointerEventData eventData)
    {
        scrollView.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        scrollView.SetActive(false);
    }
}

