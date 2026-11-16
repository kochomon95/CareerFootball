using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class PlayerAttributesPanel: MonoBehaviour
{
    public TMP_Text[] statTexts;   // 5 text slots

    void OnEnable()
    {
        List<StatEntry> list = GameManager.Instance.player.attrs.list;

        for (int i = 0; i < statTexts.Length; i++)
        {
            if (i < list.Count)
            {
                statTexts[i].gameObject.SetActive(true);
                statTexts[i].text = list[i].name + ": " + list[i].value;
            }
            else
            {
                statTexts[i].gameObject.SetActive(false);
            }
        }
    }
}