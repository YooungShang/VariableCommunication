using System.Net.Sockets;
using NModbus;
using NModbus.Device;
using NModbus.IO;
using NModbus.Logging;


namespace VariablesCore.Variable;

public class VariableModbusTcpServer : IDisposable
{
    private readonly TcpClient _tcpClient;
    private readonly IModbusMaster _modbusMaster;

    public VariableModbusTcpServer(TcpClient tcpClient)
    {
        _tcpClient = tcpClient;
    }

    public void Start()
    {
        var stream
        _modbusMaster = new ModbusIpMaster(new ModbusIpTransport(_tcpClient, ))
    }

    /// <summary>Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.</summary>
    public void Dispose()
    {
        // TODO 在此释放托管资源
    }
}