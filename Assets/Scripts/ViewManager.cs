using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    [SerializeField] List<View> viewList;

    public enum Views
    {
        None,
        Init,
        Desk
    }
    Dictionary<Views, View> viewDic = new Dictionary<Views, View>();

    private View presentView;


    public void Init()
    {
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


    // Update is called once per frame
    void Update()
    {

    }

    public void moveView(Views past,Views next)
    {
        if(past!=Views.None)
        {
            presentView.OnLeave();
        }
        presentView = viewDic[next];
        if(next!=Views.None)
        {
            presentView.onEnter();
        }
    }

    public void onClickButton(UIManager.ButtonType type)
    {
        presentView.onClickButton(type);
    }
}
