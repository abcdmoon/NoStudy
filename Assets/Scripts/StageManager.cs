using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    UIManager uiManager;
    public enum Stages
    {
        first
    }
    [SerializeField] Dictionary<Stages, Stage> stages;
    [SerializeField] Stages initialStage;

    public Stage presentStage {  get; private set; }

    public void Init(UIManager uiManager)
    {
        this.uiManager = uiManager;

        foreach (var stage in stages.Values)
        {
            stage.Init(this,uiManager);
        }

        startStage(initialStage);
    }

    public void startStage(Stages stage)
    {
        if (stages.ContainsKey(stage))
        {
            Stage target = stages[stage];
            if (target != null)
            {
                presentStage = target;
                target.onStart();
            }
        }
    }
}
