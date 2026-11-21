using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] UIManager uiManager;
    [SerializeField] StageManager stageManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiManager.Init(this);
        stageManager.Init(uiManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
