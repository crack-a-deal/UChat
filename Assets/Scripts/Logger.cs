using UnityEngine;

public static class Logger
{
    private static readonly string _serverColor = "#FF9816";
    private static readonly string _clientColor = "#167DFF";


    public static void LogServer(string message)
    {
        Debug.Log($"<color={_serverColor}>[Server]</color> {message}");
    }

    public static void LogClient(string message)
    {
        Debug.Log($"<color={_clientColor}>[Client]</color> {message}");
    }
}