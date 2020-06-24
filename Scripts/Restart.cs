
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void restart_game()
    {
        print("restarting game");
        SceneManager.LoadScene("SampleScene");
    }
}
