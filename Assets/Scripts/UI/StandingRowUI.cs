using TMPro;
using UnityEngine;

public class StandingRowUI : MonoBehaviour
{
    [SerializeField] private TMP_Text posText;
    [SerializeField] private TMP_Text teamText;
    [SerializeField] private TMP_Text playedText;
    [SerializeField] private TMP_Text wonText;
    [SerializeField] private TMP_Text drawnText;
    [SerializeField] private TMP_Text lostText;
    [SerializeField] private TMP_Text gdText;
    [SerializeField] private TMP_Text ptsText;

    public void SetData(int pos, string team, int p, int w, int d, int l, int gd, int pts)
    {
        posText.text = pos.ToString();
        teamText.text = team;
        playedText.text = p.ToString();
        wonText.text = w.ToString();
        drawnText.text = d.ToString();
        lostText.text = l.ToString();
        gdText.text = gd.ToString();
        ptsText.text = pts.ToString();
    }
}