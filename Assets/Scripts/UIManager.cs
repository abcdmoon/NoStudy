using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] Canvas mainCanvas;
    [SerializeField] List<InteractiveUI> interactiveUIList;

    private GameManager gameManager;

    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;

        foreach (InteractiveUI ui in interactiveUIList)
        {
            ui.Init(this);
        }

    }

    public void onInteracted(InteractiveUI interactiveUI)
    {
        gameManager.viewManager.onInteractedUI(interactiveUI);
    }

    public void applyViewUISetting(IReadOnlyList<InteractiveUI> setting)
    {
        foreach(InteractiveUI ui in interactiveUIList)
        {
            if (setting.Contains(ui))
            {
                
                ui.enable();
            }
            else
            {
                ui.disable();
            }
        }
    }
}
