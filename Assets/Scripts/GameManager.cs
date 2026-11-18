using UnityEngine;

public class GameManager : MonoBehaviour
{
    [field:SerializeField] public ViewManager viewManager { get; private set; }
    [SerializeField] UIManager uiManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiManager.Init(this);
        viewManager.Init();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
