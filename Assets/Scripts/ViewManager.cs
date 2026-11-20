using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    public UIManager uiManager { get; private set; }

    [SerializeField] List<View> viewList;

    public enum Views
    {
        None,
        Init,
        Desk,
        LeftWall
    }
    Dictionary<Views, View> viewDic = new Dictionary<Views, View>();

    public View presentView {  get; private set; }


    public void Init(UIManager uIManager)
    {

        uiManager = uIManager;


        if (viewList == null)
        {
            viewList = new List<View>();
        }

        foreach (View view in viewList)
        {
            viewDic.Add(view.viewName, view);
            view.Init(this);
        }

        moveView(Views.None,Views.Init);
    }


    public void moveView(Views past,Views next)
    {
        if(past!=Views.None)
        {
            presentView.onLeaveView();
        }
        if(next!=Views.None)
        {
            presentView = viewDic[next];
            presentView.onEnterView();
        }
    }

    public void onInteractedUI(InteractiveUI interactiveUI)
    {
        presentView.onInteractedUI(interactiveUI);
    }
}
