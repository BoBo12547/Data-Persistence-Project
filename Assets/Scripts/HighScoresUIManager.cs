using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HighScoresUIManager : MonoBehaviour
{
    public List<TextMeshProUGUI> highScores = new List<TextMeshProUGUI>(5);
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < GameManager.Instance.BestPlayerName.Count; i++)
        {
            highScores[i].text = (i+1)+") " + GameManager.Instance.BestPlayerName[i] + " : " + GameManager.Instance.Points[i];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
