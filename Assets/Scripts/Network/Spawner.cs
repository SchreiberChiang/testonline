using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;
using Fusion.Sockets;
using System;

public class Spawner : MonoBehaviour ,INetworkRunnerCallbacks
{

    public NetworkPlayer playerPrefab;//���Ԥ�Ƽ�
    void Start()
    {
        
    }

    public void OnPlayerJoined(NetworkRunner runner,PlayerRef player)//�������ϲ������
    {
        if (runner.IsServer)//��������Ƿ�����
        {
            Debug.Log("��Ҽ�����������������");
            ///    ����Ԥ�Ƽ�       ���Ԥ�Ƽ���λ��               ��Ԫ����ǰ         Ȼ������ҵõ��¼�
            runner.Spawn(playerPrefab, Utils.GetRandomSpawnPoint(), Quaternion.identity, player);
        }
        else Debug.Log("��Ҽ���");
    }

    public void OnInput(NetworkRunner runner,NetworkInput input)
    {//��ȡ���벢���͵����磬���������ж���

    }

    public void OnConnectedToServer(NetworkRunner runner) { Debug.Log("���ӵ�������?"); }

    public void OnPlayerLeft(NetworkRunner runner,PlayerRef player) { }

    public void OnInputMissing(NetworkRunner runner, PlayerRef player,NetworkInput input) { }

    public void OnShutdown(NetworkRunner runner,ShutdownReason shutdownReason) { Debug.Log("�ر�"); }

    public void OnDisconnectedFromServer(NetworkRunner runner) { Debug.Log("�ӷ������Ͽ�����?"); }

    public void OnConnectRequest(NetworkRunner runner, NetworkRunnerCallbackArgs.ConnectRequest request, byte[] token) { Debug.Log("���ӵ�������?"); }

    public void OnConnectFailed(NetworkRunner runner,NetAddress remoteAddress,NetConnectFailedReason reason) { Debug.Log("����ʧ��"); }

    public void OnUserSimulationMessage(NetworkRunner runner,SimulationMessagePtr message) { }

    public void OnSessionListUpdated(NetworkRunner runner, List<SessionInfo> sessionList) { }

    public void OnCustomAuthenticationResponse(NetworkRunner runner, Dictionary<string, object> data) { }

    public void OnHostMigration(NetworkRunner runner,HostMigrationToken hostMigrationToken) { }

    public void OnReliableDataReceived(NetworkRunner runner,PlayerRef player, ArraySegment<byte> data) { }
    
    public void OnSceneLoadDone(NetworkRunner runner) { }

    public void OnSceneLoadStart(NetworkRunner runner) { }



}
