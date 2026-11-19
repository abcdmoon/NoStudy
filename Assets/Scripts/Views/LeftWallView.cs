using UnityEngine;

public class LeftWallView : View
{

    public override ViewManager.Views viewName => ViewManager.Views.LeftWall;

    public override void onInteractedUI(InteractiveUI interactiveUI)
    {
        if(interactiveUI is MoveButton moveButton)
        {
            switch (moveButton.type)
            {
                case MoveButton.ButtonType.Right:
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


}
