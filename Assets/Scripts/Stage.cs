using UnityEngine;

public class Stage : MonoBehaviour
{
    [field:SerializeField] public ViewManager viewManager { get; private set; }
    StageManager stageManager;
    UIManager uiManager;

    public void Init(StageManager stageManager,UIManager uiManager)
    {
        this.stageManager = stageManager;
        this.uiManager = uiManager;

        viewManager.Init(uiManager,this);
    }


}
