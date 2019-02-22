using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class game : MonoBehaviour
{
    public Text[] b;
    public int d=0;
    public Text c;
    public GameObject s;
    public void x()
    {
        d = 1;
    }
    public void o()
    {
        d = 2;
    }
    public void S()
    {
        SceneManager.LoadScene("start");
    }
}
