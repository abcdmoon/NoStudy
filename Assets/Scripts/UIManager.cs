using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public enum ButtonType
    {
        Right,
        Left
    }

    [SerializeField] Dictionary<ButtonType, Button> buttons;

    private GameManager gameManager;

    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;

        foreach (var (type,button) in buttons)
        {
            button.onClick.AddListener(()=>onClickButton(type));
        }
    }

    private void onClickButton(ButtonType type)
    {
        gameManager.viewManager.onClickButton(type);
    }
}
