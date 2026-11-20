using UnityEngine;
using UnityEngine.EventSystems;

public class DeskView : View
{
    public override ViewManager.Views viewName => ViewManager.Views.Desk;
    public override void onInteractedUI(InteractiveUI interactiveUI)
    {
        if(interactiveUI is MoveButton moveButton)
        {
            switch (moveButton.type)
            {
                case MoveButton.ButtonType.Down:
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
