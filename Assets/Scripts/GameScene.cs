using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameScene : MonoBehaviour
{
    #region Variables

    public Text contentQuestion;
    public Image questionImage;
    public QuestionSO gameStart;
    public Text answer1;
    public Text answer2;
    public Text answer3;
    public Text answer4;

    private QuestionSO _currentQuestion;
    private int _userAnswers;
    private int _countRight;
    private int _countWrong;
    private int _questNumber;

    #endregion

    #region UnityLifeCycle

    public void Start()
    {
        CurrentQuestion(gameStart);
    }

    public void Update()
    {
    }

    #endregion

    #region PublicMethods

    public void CurrentQuestion(QuestionSO nextQuestion)
    {
        _currentQuestion = nextQuestion;
        contentQuestion.text = _currentQuestion.question;
        questionImage.sprite = _currentQuestion.locationImage;
        answer1.text = _currentQuestion.answer1;
        answer2.text = _currentQuestion.answer2;
        answer3.text = _currentQuestion.answer3;
        answer4.text = _currentQuestion.answer4;
        _userAnswers = _currentQuestion.rightAnswerIs;
        _questNumber = _currentQuestion.questionNumber;
        IsGameOver();
        Debug.Log($"{_countRight}");
        Debug.Log($"{_countWrong}");
    }

    public void OnClick()
    {
        CurrentQuestion(_currentQuestion.nextAnswer);
        IsRightAnswer();
    }

    public void IsRightAnswer()
    {
        if (_currentQuestion.rightAnswerIs == _userAnswers)
        {
            _countRight++;
        }
        else
        {
            _countWrong++;
        }
    }

    public void IsGameOver()
    {
        if (_questNumber == 6)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }


    public void ClickAnswer(QuestionSO nextQuestion)
    {
        CurrentQuestion(nextQuestion);
    }

    public void SetRightAnswer1()
    {
        _userAnswers = 1;
    }

    public void SetRightAnswer2()
    {
        _userAnswers = 2;
    }

    public void SetRightAnswer3()
    {
        _userAnswers = 3;
    }

    public void SetRightAnswer4()
    {
        _userAnswers = 4;
    }

    #endregion
}