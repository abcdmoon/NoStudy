using UnityEngine;
using UnityEngine.UI;

public class MoveButton : InteractiveUI
{
    public enum ButtonType
    {
        Right,
        Left, Up, Down
    }

    [field:SerializeField] public ButtonType type { get;private set; }

    protected override void onInit(UIManager uIManager)
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(onInteracted);
        }else
        {
            Debug.LogError(this.gameObject.name + "にボタンがアタッチされていません！");
        }
    }
}
