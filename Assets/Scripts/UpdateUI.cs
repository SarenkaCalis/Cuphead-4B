using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    [SerializeField] Text hptext;
    void Start()
    {
        hptext = GetComponentInParent<Text>();
    }
    public void ChangeUI(int currentHealth)
    {
        hptext.text = "HP: " + currentHealth;
    }
}
