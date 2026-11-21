using UnityEngine;
using UnityEngine.UI;

public class MoveButton : InteractiveUI
{
    [SerializeField] View targetView;

    protected override void onInit()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(()=>stage.viewManager.moveView(targetView));
        }else
        {
            Debug.LogError(this.gameObject.name + "にボタンがアタッチされていません！");
        }
    }


}
