using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class View : MonoBehaviour
{
    [SerializeField] GameObject viewRoot;
    public abstract ViewManager.Views viewName {  get; }
    protected ViewManager viewManager;
    protected UIManager uiManager;

    [SerializeField] List<InteractiveUI> activeUIList;

    IReadOnlyList<InteractiveUI> _activeUIList => activeUIList;

    public void Init(ViewManager viewManager)
    {
        this.viewManager = viewManager;
        this.uiManager = viewManager.uiManager;

        viewRoot.SetActive(false);

        onInit();
    }

    protected abstract void onInit();

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onEnterView()
    {
        viewRoot.SetActive(true);
        uiManager.applyViewUISetting(_activeUIList);
    }

    public void onLeaveView()
    {
        viewRoot.SetActive(false);
    }

    public abstract void onInteractedUI(InteractiveUI interactiveUI);

    public abstract void onPointerClick(PointerEventData eventData, InteractiveObject interactiveObject);

    public abstract void onPointerEnter(PointerEventData eventData, InteractiveObject interactiveObject);

    public abstract void onPointerExit(PointerEventData eventData, InteractiveObject interactiveObject);
}
