using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> traps;
    public static LevelManager inst;
    public TextMeshPro txtLevel;

    int level = 1;


    private void Awake()
    {
        if (inst == null)
            inst = this;
        else
            Destroy(this);
    }

    public void LoadTrap()
    {
        for (int i = 0; i < traps.Count; i++)
        {
            if (!traps[i].activeSelf)
            {
                traps[i].SetActive(true);

                txtLevel.text = (++level).ToString();

                return;
            }
        }

        //reset
        for (int i = 0; i < traps.Count; i++)
        {
            traps[i].SetActive(false);
        }
        level = 1;
        txtLevel.text = level.ToString();
    }


}
