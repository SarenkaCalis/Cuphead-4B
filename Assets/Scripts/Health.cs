using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] Text hptext;
    // Start is called before the first frame update
    void Start()
    {
        hptext = GetComponentInParent<Text>();
    }


    public void TakeDamage()
    {
        health += -1;
        UpdateUI();
    }
    private void UpdateUI()
    {
        hptext.text = "HP: " + health;
    }
}
