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
        health = 3;
        hptext = GetComponentInParent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        hptext.text = "HP: " + health;
    }
    public void TakeDamage()
    {
        health += -1;
    }
}
