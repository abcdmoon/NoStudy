using System.Collections.Generic;
using Objects;
using UnityEngine;

public class View : MonoBehaviour
{
    GameObject viewRoot;
    [SerializeField] GameObject uiRoot;
    protected ViewManager viewManager;
    protected UIManager uiManager;
    protected Stage stage;

    List<InteractiveUI> activeUIList = new List<InteractiveUI>();
    List<InteractiveObject> activeObjects = new List<InteractiveObject>();
    List<DynamicObject> dynamicObjects = new List<DynamicObject>();


    public void Init(Stage stage)
    {
        viewRoot = this.gameObject;
        if(uiRoot == null)
        {
            Debug.LogError(this.gameObject.name + "ビューにUIルートがアタッチされていません！");
        }

        this.stage = stage;
        viewManager = stage.viewManager;
        uiManager = stage.uiManager;

        viewRoot.SetActive(false);
        uiRoot.SetActive(false);

        viewRoot.GetComponentsInChildren(true, activeObjects);
        viewRoot.GetComponentsInChildren(true, dynamicObjects);
        uiRoot.GetComponentsInChildren(true,activeUIList);

        foreach(InteractiveObject obj in activeObjects)
        {
            obj.Init(stage, this);
        }

        foreach (DynamicObject obj in dynamicObjects)
        {
            obj.Init(stage, this);
        }
        foreach (InteractiveUI ui in activeUIList)
        {
            ui.Init(stage, this);
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
