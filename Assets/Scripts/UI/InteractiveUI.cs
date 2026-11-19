using UnityEngine;

public abstract class InteractiveUI : MonoBehaviour
{
    protected UIManager uiManager;
    public void Init(UIManager uIManager)
    {
        this.uiManager = uIManager;
        this.gameObject.SetActive(false);

        onInit(uIManager);
    }

    protected abstract void onInit(UIManager uIManager);

    protected void onInteracted()
    {
        uiManager.onInteracted(this);
    }

    public void enable()
    {
        this.gameObject.SetActive(true);
        Debug.Log(this.gameObject.name+"‚ª—LŒø‰»‚³‚Á‚ê‚½");
    }

    public void disable()
    {
        this .gameObject.SetActive(false);
        Debug.Log(this.gameObject.name + "‚ª–³Œø‰»‚³‚Á‚ê‚½");
    }
}
