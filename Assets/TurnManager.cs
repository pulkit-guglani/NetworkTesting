using UnityEngine;
using SWNetwork;

public class TurnManager : MonoBehaviour
{
    private SyncPropertyAgent syncAgent;
    private NetworkID nID;

    private const string TURN = "Turn";

    private void Start()
    {
        syncAgent = GetComponent<SyncPropertyAgent>();
        nID = GetComponent<NetworkID>();
    }

    public void ChangeTurn()
    {
        if(syncAgent.GetPropertyWithName(TURN).GetIntValue() == 1)
        {
            syncAgent.Modify(TURN, 2);
        }
        else
        {
            syncAgent.Modify(TURN, 1);
        }
    }
}
