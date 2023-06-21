using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;

    private void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null)
        {
            player = playerObject.transform;
        }
        else
        {
            Debug.LogError("Could not find player object with tag 'Player'. Make sure the player has the correct tag.");
        }

        agent = GetComponent<NavMeshAgent>();
    }


    private void Update()
    {

        if (agent.isOnNavMesh)
        {
            if (player != null)
            {
                agent.SetDestination(player.position);
            }
        }
    }
}
