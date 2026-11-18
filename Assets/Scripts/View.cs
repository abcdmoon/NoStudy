using UnityEngine;

public abstract class View : MonoBehaviour
{
    [SerializeField] GameObject viewRoot;
    public ViewManager.Views viewName {  get; protected set; }
    protected ViewManager viewManager;

    public void Init(ViewManager viewManager)
    {
        this.viewManager = viewManager;

        viewRoot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onEnter()
    {
        viewRoot.SetActive(true);
    }

    public void OnLeave()
    {
        viewRoot.SetActive(false);
    }

    public abstract void onClickButton(UIManager.ButtonType buttonType);
}
