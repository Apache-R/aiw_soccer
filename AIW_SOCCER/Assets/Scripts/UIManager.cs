using UnityEngine;
using UnityEngine.SceneManagement;


public class UIManager : MonoBehaviour
{
    public const string FieldScene = "Field";
    public const string SmallRoom = "Small Room";
    public const string MainScene = "Main Scene";
    public void StartGame()
    {
        SceneManager.LoadScene(FieldScene);
    }

    public void StartTrainingGame(){
        SceneManager.LoadScene(SmallRoom);            
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(MainScene);
    }
}