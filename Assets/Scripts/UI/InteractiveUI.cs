using UnityEngine;

public abstract class InteractiveUI : MonoBehaviour
{
    [SerializeField] bool isInitial;

    protected Stage stage;
    protected View view;
    public void Init(Stage stage,View view)
    {
        this.stage = stage;
        this.view = view;

        this.gameObject.SetActive(isInitial);

        onInit();
    }

    protected abstract void onInit();

    public void enable()
    {
        this.gameObject.SetActive(true);
    }

    public void disable()
    {
        this .gameObject.SetActive(false);
    }
}
