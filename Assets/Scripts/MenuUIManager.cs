
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIManager : MonoBehaviour
{
    public TMP_InputField playerName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMainScene()
    {
        GameManager.Instance.PlayerName = playerName.text;
        SceneManager.LoadScene(1);
    }

    public void GoToHighScoreScene()
    {
        
        SceneManager.LoadScene(2);
    }

    public void ExitScene()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}
