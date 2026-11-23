using UnityEngine;

public class Stage : MonoBehaviour
{
    public ViewManager viewManager { get; private set; }
    private StageManager stageManager;
    public UIManager uiManager { get; private set; }

    [SerializeField] private View initialView;

    public void Init(StageManager stageManager,UIManager uiManager)
    {
        this.stageManager = stageManager;
        this.uiManager = uiManager;

        viewManager = new ViewManager();
        viewManager.Init(this);
    }

    public void onStart()
    {
        viewManager.moveView(initialView);
    }


}
