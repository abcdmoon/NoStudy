using UnityEngine;

public class DeskView : View
{
    public DeskView()
    {
        viewName = ViewManager.Views.Desk;
    }

    public override void onClickButton(UIManager.ButtonType type)
    {
        switch (type)
        {
            case UIManager.ButtonType.Left:
                {
                    viewManager.moveView(viewName, ViewManager.Views.Init);
                    return;
                }
            default:
                {
                    break;
                }
        }
    }

}
