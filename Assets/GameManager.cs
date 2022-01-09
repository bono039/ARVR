using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{

    public int score;
    public int drop;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    // Start is called before the first frame update
    void Awake()
    {
        if (!PlayerPrefs.HasKey("highScore"))
        {
            PlayerPrefs.SetInt("highScore", 0);
        }
        highscoreText.text = PlayerPrefs.GetInt("highScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void LateUpdate()
    {
        scoreText.text = score.ToString();

    }

    public void GameOver()
    {
        int highScore = PlayerPrefs.GetInt("highScore");
        PlayerPrefs.SetInt("highScore", Mathf.Max(score, highScore));

        bool b = EditorUtility.DisplayDialog("³¡", "Bye", "OK");

        if (b)
        {
            SceneManager.LoadScene(0);
        }
    }
}
