using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
    public TextMeshProUGUI bestScore;
    public TMP_InputField textBox;

    // Start is called before the first frame update
    void Start()
    {
        bestScore.text = string.Format("Best Score : {0} : {1}", HighScoreManager.Instance.highScorePlayerName, HighScoreManager.Instance.highScore);
        textBox.text = HighScoreManager.Instance.highScorePlayerName;
    }

    public void StartNew()
    {
        HighScoreManager.Instance.currentPlayerName = textBox.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
