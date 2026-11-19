using System.Collections.Generic;
using UnityEngine;

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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onEnter()
    {
        viewRoot.SetActive(true);
        uiManager.applyViewUISetting(_activeUIList);
    }

    public void OnLeave()
    {
        viewRoot.SetActive(false);
    }

    public abstract void onInteractedUI(InteractiveUI interactiveUI);
}
