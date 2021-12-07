using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeammateManager : MonoBehaviour
{
    public GameObject UIOriginal;
    public  List<CharacterStat> Characters ;

    //public List<GameObject> UIs;

    public Dictionary<string, GameObject> UIs = new Dictionary<string, GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
        //Anadir HUD del primer personaje
        GameObject protagonist = GameObject.FindGameObjectWithTag("Player");
        CharacterStat stat = protagonist.GetComponent<CharacterStat>();
        
        Characters.Add(stat);

        GameObject UIClone = Instantiate(UIOriginal);
        UIClone.SetActive(true);
        //UIs.Add(stat.GetID(),UIClone);
    }

    // Update is called once per frame
    void Update()
    {
        RectTransform UIpos = UIOriginal.GetComponent<RectTransform>();
        Vector2 posi = UIpos.anchoredPosition;

        Vector3 newPos = new Vector3((float)posi.x + 10, (float)posi.y+10, (float)20);
        GameObject UIClone = Instantiate(UIOriginal,newPos, Quaternion.identity);
        UIClone.SetActive(true);
        UIs.Add(Random.Range(0,100).ToString(), UIClone);

    }
}
