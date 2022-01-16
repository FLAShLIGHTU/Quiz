using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
  public void LoadGameScene()
  {
    SceneManager.LoadScene("GameScene");
  }

  public void GameOverScene()
  {
    SceneManager.LoadScene("GameOverScene");
  }
  //HelloWorld
}