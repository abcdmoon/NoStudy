using UnityEngine;
using UnityEngine.EventSystems;

public class InitView : View
{

    public override ViewManager.Views viewName => ViewManager.Views.Init;

    public override void onInteractedUI(InteractiveUI interactiveUI)
    {
        if(interactiveUI is MoveButton moveButton)
        {
            switch (moveButton.type)
            {
                case MoveButton.ButtonType.Left:
                    {
                        viewManager.moveView(viewName, ViewManager.Views.LeftWall);
                        return;
                    }
                case MoveButton.ButtonType.Down:
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

    public override void onPointerClick(PointerEventData eventData, InteractiveObject interactiveObject)
    {
    }

    public override void onPointerEnter(PointerEventData eventData, InteractiveObject interactiveObject)
    {
    }

    public override void onPointerExit(PointerEventData eventData, InteractiveObject interactiveObject)
    {
    }

    protected override void onInit()
    {
    }
}
