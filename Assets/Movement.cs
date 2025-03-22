using UnityEngine;
using UnityEngine.AI;
public class Movement : MonoBehaviour
{
    [SerializeField] Transform target;

    NavMeshAgent agent;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            agent.SetDestination(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
}
