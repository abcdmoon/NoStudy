using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class View : MonoBehaviour
{
    GameObject viewRoot;
    [SerializeField] GameObject uiRoot;
    protected ViewManager viewManager;
    protected UIManager uiManager;
    protected Stage stage;

    [SerializeField] List<InteractiveUI> activeUIList;
    [SerializeField] List<InteractiveObject> activeObjects;


    public void Init(ViewManager viewManager,Stage stage)
    {
        viewRoot = this.gameObject;

        this.viewManager = viewManager;
        this.uiManager = viewManager.uiManager;
        this.stage = stage;

        viewRoot.SetActive(false);
        uiRoot.SetActive(false);

        foreach(InteractiveUI ui in activeUIList)
        {
            ui.Init(stage, this);
        }
        foreach(InteractiveObject obj in activeObjects)
        {
            obj.Init(stage, this);
        }
    }

    public void onEnterView()
    {
        viewRoot.SetActive(true);
        uiRoot.SetActive(true);
    }

    public void onLeaveView()
    {
        viewRoot.SetActive(false);
        uiRoot.SetActive(false);
    }

}
