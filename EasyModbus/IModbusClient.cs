﻿/*
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

namespace EasyModbus
{
    public interface IModbusClient
    {
        int Baudrate { get; set; }
        bool Connected { get; }
        int ConnectionTimeout { get; set; }
        string IPAddress { get; set; }
        string LogFileFilename { get; set; }
        int NumberOfRetries { get; set; }
        Parity Parity { get; set; }
        int Port { get; set; }
        string SerialPort { get; set; }
        StopBits StopBits { get; set; }
        bool UDPFlag { get; set; }
        byte UnitIdentifier { get; set; }

        event ModbusClient.ConnectedChangedHandler ConnectedChanged;
        event ModbusClient.ReceiveDataChangedHandler ReceiveDataChanged;
        event ModbusClient.SendDataChangedHandler SendDataChanged;

        bool Available(int timeout);
        void Connect();
        void Connect(string ipAddress, int port);
        void Disconnect();
        bool[] ReadCoils(int startingAddress, int quantity);
        bool[] ReadDiscreteInputs(int startingAddress, int quantity);
        int[] ReadHoldingRegisters(int startingAddress, int quantity);
        int[] ReadInputRegisters(int startingAddress, int quantity);
        int[] ReadWriteMultipleRegisters(int startingAddressRead, int quantityRead, int startingAddressWrite, int[] values);
        void WriteMultipleCoils(int startingAddress, bool[] values);
        void WriteMultipleRegisters(int startingAddress, int[] values);
        void WriteSingleCoil(int startingAddress, bool value);
        void WriteSingleRegister(int startingAddress, int value);
    }
}