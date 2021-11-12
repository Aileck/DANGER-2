using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetStress : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject SomeOne;
    private CharacterStat Stat;

    public Slider Scrollbar;

    // Start is called before the first frame update
    void Start()
    {
        Stat = SomeOne.GetComponent<CharacterStat>();
    }

    // Update is called once per frame
    void Update()
    {
        Scrollbar.value = (float)Stat.GetCurrentStress() / (float)Stat.GetMaxStress();
    }

}
