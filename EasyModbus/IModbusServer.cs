/*
Copyright (c) 2018-2020 Rossmann-Engineering
Permission is hereby granted, free of charge, 
to any person obtaining a copy of this software
and associated documentation files (the "Software"),
to deal in the Software without restriction, 
including without limitation the rights to use, 
copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit 
persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission 
notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, 
DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using System.IO.Ports;
using System.Net;

namespace EasyModbus
{
    public interface IModbusServer
    {
        int Baudrate { get; set; }
        bool FunctionCode15Disabled { get; set; }
        bool FunctionCode16Disabled { get; set; }
        bool FunctionCode1Disabled { get; set; }
        bool FunctionCode23Disabled { get; set; }
        bool FunctionCode2Disabled { get; set; }
        bool FunctionCode3Disabled { get; set; }
        bool FunctionCode4Disabled { get; set; }
        bool FunctionCode5Disabled { get; set; }
        bool FunctionCode6Disabled { get; set; }
        IPAddress LocalIPAddress { get; set; }
        string LogFileFilename { get; set; }
        ModbusProtocol[] ModbusLogData { get; }
        int NumberOfConnections { get; }
        Parity Parity { get; set; }
        int Port { get; set; }
        bool PortChanged { get; set; }
        bool SerialFlag { get; set; }
        string SerialPort { get; set; }
        StopBits StopBits { get; set; }
        bool UDPFlag { get; set; }
        byte UnitIdentifier { get; set; }

        event ModbusServer.CoilsChangedHandler CoilsChanged;
        event ModbusServer.HoldingRegistersChangedHandler HoldingRegistersChanged;
        event ModbusServer.LogDataChangedHandler LogDataChanged;
        event ModbusServer.NumberOfConnectedClientsChangedHandler NumberOfConnectedClientsChanged;

        void Listen();
        void StopListening();
    }
}