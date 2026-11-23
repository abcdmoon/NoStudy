using UnityEngine;
using System.Collections.Generic;

public class ViewManager
{
    Stage stage;

    List<View> viewList;

    public View presentView {  get; private set; }


    public void Init(Stage stage)
    {
        this.stage = stage;

        if (viewList == null)
        {
            viewList = new List<View>();
        }

        stage.gameObject.GetComponentsInChildren<View>(true,viewList);

        foreach (View view in viewList)
        {
            view.Init(stage);
        }
    }


    public void moveView(View next)
    {
        if (next == null) { Debug.LogError("moveView: 遷移先が未設定です"); return; }
        if (presentView!=null)
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
