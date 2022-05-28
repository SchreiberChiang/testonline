using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using Fusion.Sockets;
using System;

public class Spawner : MonoBehaviour ,INetworkRunnerCallbacks
{

    public NetworkPlayer playerPrefab;//玩家预制件
    void Start()
    {
        
    }

    public void OnPlayerJoined(NetworkRunner runner,PlayerRef player)//当世界上产生玩家
    {
        if (runner.IsServer)//如果我们是服务器
        {
            Debug.Log("玩家加入服务器，生成玩家");
            ///    生成预制件       随机预制件的位置               四元数朝前         然后让玩家得到事件
            runner.Spawn(playerPrefab, Utils.GetRandomSpawnPoint(), Quaternion.identity, player);
        }
        else Debug.Log("玩家加入");
    }

    public void OnInput(NetworkRunner runner,NetworkInput input)
    {//获取输入并发送到网络，主机可以行动？

    }

    public void OnConnectedToServer(NetworkRunner runner) { Debug.Log("连接到服务器?"); }

    public void OnPlayerLeft(NetworkRunner runner,PlayerRef player) { }

    public void OnInputMissing(NetworkRunner runner, PlayerRef player,NetworkInput input) { }

    public void OnShutdown(NetworkRunner runner,ShutdownReason shutdownReason) { Debug.Log("关闭"); }

    public void OnDisconnectedFromServer(NetworkRunner runner) { Debug.Log("从服务器断开连接?"); }

    public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token) { Debug.Log("连接到服务器?"); }

    public void OnConnectFailed(NetworkRunner runner,NetAddress remoteAddress,NetConnectFailedReason reason) { Debug.Log("连接失败"); }

    public void OnUserSimulationMessage(NetworkRunner runner,SimulationMessagePtr message) { }

    public void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList) { }

    public void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data) { }

    public void OnHostMigration(NetworkRunner runner,HostMigrationToken hostMigrationToken) { }

    public void OnReliableDataReceived(NetworkRunner runner,PlayerRef player, ArraySegment<byte> data) { }
    
    public void OnSceneLoadDone(NetworkRunner runner) { }

    public void OnSceneLoadStart(NetworkRunner runner) { }



}
