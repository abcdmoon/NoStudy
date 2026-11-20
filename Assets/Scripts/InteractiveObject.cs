using UnityEngine;
using UnityEngine.EventSystems;

public class InteractiveObject : MonoBehaviour, IPointerClickHandler,IPointerEnterHandler,IPointerExitHandler
{
    ViewManager viewManager;
    public void Init(ViewManager viewManager)
    {
        this.viewManager = viewManager;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        viewManager.presentView.onPointerClick(eventData,this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        viewManager.presentView.onPointerEnter(eventData,this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        viewManager.presentView.onPointerExit(eventData,this);
    }
}
