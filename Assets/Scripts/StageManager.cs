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

    public void Init(UIManager uiManager)
    {
        this.uiManager = uiManager;

        foreach (var stage in stages.Values)
        {
            stage.Init(this,uiManager);
        }
    }
}
