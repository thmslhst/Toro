using UnityEngine;
using System.Collections.Generic;

public class OtoroEater : MonoBehaviour
{
    private Dictionary<string, ServerLog> servers = new Dictionary<string, ServerLog>();
    private List<object> fft = new List<object>();

    private string _address = "/otoro";

    //-------------------------------------------

    public float getFFT(int index)
    {
        float amplitude = 0.0F;

        if(fft.Count > 0){
            amplitude = (float) fft[index] / 255;
        }

        return amplitude;
    }

    //-------------------------------------------

    void Start()
    {
        OSCHandler.Instance.Init();
        servers = OSCHandler.Instance.Servers;
    }

    //-------------------------------------------

    void Update()
    {
        OSCHandler.Instance.UpdateLogs();

        foreach(KeyValuePair<string, ServerLog> item in servers)
        {
            if (item.Value.log.Count > 0)
            {
                int lastPacketIndex = item.Value.packets.Count - 1;

                //string serverName = item.Key;
                string address = item.Value.packets[lastPacketIndex].Address;

                if(address == _address)
                {  
                    fft = item.Value.packets[lastPacketIndex].Data;
                }
            }
        }
    }
}
