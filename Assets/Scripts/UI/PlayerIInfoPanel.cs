using TMPro;
using UnityEngine;
using static UnityEngine.LowLevelPhysics2D.PhysicsLayers;

public class PlayerInfoPanel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TMP_Text playerName;
    public TMP_Text height;
    public TMP_Text weight;
    public TMP_Text position;
    public TMP_Text preferredFoot;
    public TMP_Text nationality;

    void Start()
    {
        PlayerData p = GameManager.Instance.player;
        playerName.text = p.playerName;
        height.text = p.height.ToString() + "KG";
        weight.text = p.weight.ToString() + "CM";
        position.text = p.position;
        preferredFoot.text = p.preferredFoot;
        nationality.text = p.nationality;
    }
}
