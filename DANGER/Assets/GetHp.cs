using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHp : MonoBehaviour
{
    public GameObject SomeOne;
    private CharacterStat Stat;

    public Slider Scrollbar;

    // Start is called before the first frame update
    void Start()
    {
        Scrollbar = GetComponent<Slider>();
        Stat = SomeOne.GetComponent<CharacterStat>();
    }

    // Update is called once per frame
    void Update()
    {
        Scrollbar.value = (float)Stat.GetCurrentHp() / (float)Stat.GetMaxHp();
    }

}
