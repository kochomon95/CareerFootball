using TMPro;
using UnityEngine;
public class TeamListUI : MonoBehaviour
{
    //[SerializeField] private TMP_Text teamListText;
    [SerializeField] private StandingRowUI rowPrefab;
    [SerializeField] private Transform container;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TextAsset file = Resources.Load<TextAsset>("Teams");
        if (file == null)
        {
            Debug.LogError("teamData not found in Resources");
            return;
        }

        TeamDatabase db = JsonUtility.FromJson<TeamDatabase>(file.text);
        if (db == null || db.teams == null || db.teams.Count == 0)
        {
            Debug.LogError("JSON does not match the model");
            return;
        }
        Debug.Log("Teams loaded: " + db.teams.Count);

        int position = 1;
        foreach (TeamData t in db.teams)
        {
            StandingRowUI row = Instantiate(rowPrefab, container);   // 1. make a row
            row.SetData(position, t.teamName, 0, 0, 0, 0, 0, 0);    // 2. fill it
            position++;
        }
    }


}
