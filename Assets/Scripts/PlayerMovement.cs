
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private int gridSize = 1;

    [SerializeField] public Camera mainCamera;
    public NavMeshAgent agent;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition); //variable save information from mouse screen position
            RaycastHit hit; //variable save ray hit position


            if (Physics.Raycast(ray, out hit)) //ray hits an object = true. if ray doesn't hit an object, then false
            {
                //move agent
                agent.SetDestination(hit.point);
            }
        }
        
       
    }

    
}
