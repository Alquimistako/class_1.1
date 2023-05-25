using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
	public void StartGame()
	{
		SceneManager.LoadScene("遊戲場景");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}
