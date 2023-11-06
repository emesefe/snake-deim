using UnityEngine;
using UnityEngine.UI;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private Button restartButton;

    private void Awake()
    {
        restartButton.onClick.AddListener(() => {Loader.Load(Loader.Scene.Game);});
        //restartButton.onClick.AddListener(RestartButtonFunction);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
    
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    // private void RestartButtonFunction()
    // {
    //     Loader.Load(Loader.Scene.Game);
    // }
}
