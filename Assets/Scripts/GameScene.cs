using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{
  public Text ContentQuestion;
  public Image QuestionImage;
  public QuestionSO GameStart;
  public Text Answer1;
  public Text Answer2;
  public Text Answer3;
  public Text Answer4;
  public Text GameOverText;

  public QuestionSO _currentQuestion;
  private int RightAnswers;
  private int CountRight;
  private int CountWrong;
  private int _questNumber;

  public void Start()
  {
    CurrentQuestion(GameStart);
  }

  public void Update()
  {
  }

  public void CurrentQuestion(QuestionSO nextQuestion)
  {
    _currentQuestion = nextQuestion;
    ContentQuestion.text = _currentQuestion.Question;
    QuestionImage.sprite = _currentQuestion.LocationImage;
    Answer1.text = _currentQuestion._Answer1;
    Answer2.text = _currentQuestion._Answer2;
    Answer3.text = _currentQuestion._Answer3;
    Answer4.text = _currentQuestion._Answer4;
    RightAnswers = _currentQuestion.Answers;
    _questNumber = _currentQuestion.QuestionNumber;
    IsGameOver();
    Debug.Log($"{CountRight}");
    Debug.Log($"{CountWrong}");
  }

  public void OnClick()
  {
    CurrentQuestion(_currentQuestion.Answer);
    IsRightAnswer();
  }

  public void IsRightAnswer()
  {
    if (_currentQuestion.Answers == RightAnswers)
    {
      CountRight++;
    }
    else
    {
      CountWrong++;
    }
  }

  public void IsGameOver()
  {
    if (_questNumber == 6)
    {
      SceneManager.LoadScene("GameOverScene");
    }

    return;
  }


  public void ClickAnswer(QuestionSO nextQuestion)
  {
    CurrentQuestion(nextQuestion);
  }

  public void SetRightAnswer1()
  {
    RightAnswers = 1;
  }

  public void SetRightAnswer2()
  {
    RightAnswers = 2;
  }

  public void SetRightAnswer3()
  {
    RightAnswers = 3;
  }

  public void SetRightAnswer4()
  {
    RightAnswers = 4;
  }
}