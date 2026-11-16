using UnityEngine;

public class PanelSwitcher : MonoBehaviour
{
    public GameObject[] panels;   

    void Start()
    {
        ShowPanel(0);       // show the first panel when the game starts
    }

    public void ShowPanel(int index)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].SetActive(i == index);
        }
    }
}