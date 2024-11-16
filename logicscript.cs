using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicscript : MonoBehaviour
{
    public Text scoretext;
    public int playerscore;
    public GameObject gameoverscn;
    [ContextMenu("increse score")]
    public void addscore()
    {
        playerscore++;
        scoretext.text = playerscore.ToString();
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
    public void gameover(){
        gameoverscn.SetActive(true);
        Time.timeScale = 0;
    }
}
