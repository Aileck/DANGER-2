using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterMovment : MonoBehaviour
{


    public NavMeshAgent agent; //Libreria AI, para encontrar camino
    public Animator animator;
    public Light selectLight;

    public GameObject selectCircle;

    public bool underControl;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        selectLight = GetComponent<Light>();

        //Crea instancia de circulo indicador de actividad
        GameObject circleInstance = Instantiate(GameObject.FindGameObjectWithTag("TeamUI"));
        circleInstance.transform.SetParent(this.transform);
        circleInstance.transform.localPosition = Vector3.zero;
        selectCircle = circleInstance;
    }

    // Update is called once per frame
    void Update()
    {

        if (underControl)
        {
            selectLight.intensity = 1;
            selectCircle.SetActive(true);

            if (!agent.hasPath)
                animator.SetBool("Walk", false);
            else
                animator.SetBool("Walk", true);

            if (Input.GetMouseButtonDown(0))
            {
                Move();
            }
        }
        else {
            //Quitar indicador de actividad
            selectLight.intensity = 0;
            selectCircle.SetActive(false);
        }

    }

    private void Move()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray ray = Camera.main.ScreenPointToRay(mousePosition); //Un rayo de camara a cursos
        RaycastHit hit; //Cosa que vamos a chocar

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.tag == "Terrain")
            {
                agent.SetDestination(hit.point);
                transform.LookAt(hit.point);
            }
        }
    }
}
