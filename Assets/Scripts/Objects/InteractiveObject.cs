using UnityEngine;
using UnityEngine.EventSystems;

public abstract class InteractiveObject : MonoBehaviour, IPointerClickHandler,IPointerEnterHandler,IPointerExitHandler
{
    [SerializeField] bool isInitial;

    protected Stage stage;
    protected View view;
    public void Init(Stage stage,View view)
    {
        this.stage = stage;
        this.view = view;

        this.gameObject.SetActive(isInitial);
    }

    public abstract void OnPointerClick(PointerEventData eventData);
    public abstract void OnPointerEnter(PointerEventData eventData);
    public abstract void OnPointerExit(PointerEventData eventData);
}
