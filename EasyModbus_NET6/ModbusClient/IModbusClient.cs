namespace EasyModbus
{
    public interface IModbusClient
    {
        int NumberOfRetries { get; set; }

        event ModbusClient.ConnectedChangedHandler ConnectedChanged;
        event ModbusClient.ReceiveDataChangedHandler ReceiveDataChanged;
        event ModbusClient.SendDataChangedHandler SendDataChanged;

        void Connect(string ipAddress, int port);
        void Disconnect();
        bool[] ReadDiscreteInputs(int startingAddress, int quantity);
    }
}