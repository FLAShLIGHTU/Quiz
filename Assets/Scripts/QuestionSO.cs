using NaughtyAttributes;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(QuestionSO), menuName = "Settigs/Question")]
public class QuestionSO : ScriptableObject
{
    #region Variables

    [TextArea(6, 10)] public string question;
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;
    public QuestionSO nextAnswer;
    [ShowAssetPreview()] public Sprite locationImage;
    public int rightAnswerIs;
    public int questionNumber;

    #endregion
}