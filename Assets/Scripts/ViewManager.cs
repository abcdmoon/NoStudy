using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour
{
    public UIManager uiManager { get; private set; }
    public Stage stage { get; private set; }

    [SerializeField] List<View> viewList;
    [SerializeField] View initialView;

    public View presentView {  get; private set; }


    public void Init(UIManager uiManager,Stage stage)
    {
        this.uiManager = uiManager;
        this.stage = stage;

        if (viewList == null)
        {
            viewList = new List<View>();
        }

        foreach (View view in viewList)
        {
            view.Init(this,stage);
        }

        moveView(initialView);
    }


    public void moveView(View next)
    {
        if(presentView!=null)
        {
            presentView.onLeaveView();
        }
        presentView = next;
        if(presentView!=null)
        {
            presentView.onEnterView();
        }
    }
}
