using UnityEngine;

public class InitView : View
{
    public InitView() 
    {
        viewName = ViewManager.Views.Init;
    }

    public override void onClickButton(UIManager.ButtonType type)
    {
        switch (type)
        {
            case UIManager.ButtonType.Left:
                {
                    viewManager.moveView(viewName, ViewManager.Views.Desk);
                    return;
                }
            default:
                {
                    break;
                }
        }
    }


}
