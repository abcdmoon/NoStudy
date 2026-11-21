using UnityEngine;
using UnityEngine.EventSystems;

public class ActivationChanger : InteractiveObject
{
    [SerializeField] GameObject enableTarget;
    [SerializeField] GameObject disableTarget;

    public override void OnPointerClick(PointerEventData eventData)
    {
        if (enableTarget != null)
        {
            enableTarget.SetActive(true);
        }
        if (disableTarget != null)
        {
            disableTarget.SetActive(false);
        }
    }

    public override void OnPointerEnter(PointerEventData eventData)
    {
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
    }
}
