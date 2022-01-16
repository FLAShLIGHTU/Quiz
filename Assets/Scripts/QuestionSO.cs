using System.Collections;
using System.Collections.Generic;
using NaughtyAttributes;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = nameof(QuestionSO), menuName = "Settigs/Question")]
public class QuestionSO : ScriptableObject
{
  public string Question;
  public string _Answer1;
  public string _Answer2;
  public string _Answer3;
  public string _Answer4;
  public QuestionSO Answer;
  [ShowAssetPreview()] public Sprite LocationImage;
  public int Answers;
  public int QuestionNumber;
}