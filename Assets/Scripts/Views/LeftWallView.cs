using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftWallView : View
{

    public override ViewManager.Views viewName => ViewManager.Views.LeftWall;

    public enum InteractiveObjects
    {
        WallPaper,
        Back
    }

    [SerializeField] Dictionary<InteractiveObjects, InteractiveObject> interactiveObjectsDic;

    [SerializeField] GameObject wallPaper;


    protected override void onInit()
    {
        foreach(InteractiveObject obj in interactiveObjectsDic.Values)
        {
            obj.Init(viewManager);
        }
        wallPaper.SetActive(false);
    }

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

    public override void onPointerClick(PointerEventData eventData, InteractiveObject interactiveObject)
    {
        if (interactiveObject.Equals(interactiveObjectsDic[InteractiveObjects.WallPaper]))
        {
            wallPaper.SetActive(true);
            return;
        }

        if(wallPaper.activeSelf)
        {
            if (interactiveObject.Equals(interactiveObjectsDic[InteractiveObjects.Back]))
            {
                wallPaper.SetActive(false);
                return;
            }
        }
    }

    public override void onPointerEnter(PointerEventData eventData, InteractiveObject interactiveObject)
    {
    }

    public override void onPointerExit(PointerEventData eventData, InteractiveObject interactiveObject)
    {
    }

}
