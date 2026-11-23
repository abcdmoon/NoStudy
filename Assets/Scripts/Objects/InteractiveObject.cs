using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class InteractiveObject : MonoBehaviour, IPointerClickHandler,IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] bool isInitialHidden;

    protected Stage stage;
    protected View view;
    public void Init(Stage stage,View view)
    {
        this.stage = stage;
        this.view = view;

        this.gameObject.SetActive(!isInitialHidden);
    }

    private event Action<InteractiveObject, PointerEventData> clickEvent;
    public void addClickEvent(Action<InteractiveObject, PointerEventData> clickEvent){this.clickEvent += clickEvent;}
    public void removeClickEvent(Action<InteractiveObject, PointerEventData> clickEvent){this.clickEvent -= clickEvent;}
    private event Action<InteractiveObject,PointerEventData> enterEvent;
    public void addEnterEvent(Action<InteractiveObject, PointerEventData> enterEvent){this.enterEvent += enterEvent;}
    public void removeEnterEvent(Action<InteractiveObject, PointerEventData> enterEvent){this.enterEvent -= enterEvent;}
    private event Action<InteractiveObject,PointerEventData> exitEvent;
    public void addExitEvent(Action<InteractiveObject, PointerEventData> exitEvent){this.exitEvent += exitEvent;}
    public void removeExitEvent(Action<InteractiveObject, PointerEventData> exitEvent){this.exitEvent -= exitEvent;}

    public void OnPointerClick(PointerEventData eventData)
    {
        clickEvent?.Invoke(this,eventData);
        onClick(eventData);
    }

    protected virtual void onClick(PointerEventData eventData)
    {
        
    }
    
    public void OnPointerEnter(PointerEventData eventData)
    {
        enterEvent?.Invoke(this,eventData);
        onEnter(eventData);
    }

    protected virtual void onEnter(PointerEventData eventData)
    {
        
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        exitEvent?.Invoke(this,eventData);
        onExit(eventData);
    }

    protected virtual void onExit(PointerEventData eventData)
    {
        
    }
}
