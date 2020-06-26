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
        int currentTurn = syncAgent.GetPropertyWithName("Turn").GetIntValue();
        if(currentTurn == 1)
        {
            syncAgent.Modify(TURN, 2);
        }
        else
        {
            syncAgent.Modify(TURN, 1);
        }
        Debug.Log("turn online vala hai : " + syncAgent.GetPropertyWithName("Turn").GetIntValue());

      //  Debug.Log("abhi baari iski hai: "+currentTurn);
    }

    public void debugKr()
    {
        int currentTurn = syncAgent.GetPropertyWithName("Turn").GetIntValue();
        Debug.Log("abhi baari iski hai: "+currentTurn);
    }
    
}
