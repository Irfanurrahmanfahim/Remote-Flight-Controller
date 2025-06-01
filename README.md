# Remote Flight Controller (C#)

**Remote Flight Controller** is a C#-based application that allows users to **remotely control a flight simulator** over a network. By connecting to the simulator using an **IP address and port**, users can send control commands and receive flight data, enabling remote operation and monitoring.

## ✈️ Key Features

* **Remote Connection**: Connect to a flight simulator running on another machine using IP and port.
* **Real-Time Control**: Send commands for throttle, pitch, yaw, roll, flaps, and other flight controls.
* **Live Data Feedback**: Receive live telemetry and status updates from the simulator (if supported).
* **Custom UI**: Simple and responsive interface for flight control input.

## 🛠 Technologies Used

* **C#** – Core application logic and UI
* **.NET Framework / .NET Core** – Depending on the project version
* **TCP/UDP Sockets** – For network communication with the flight simulator
* *(Optional: WPF or Windows Forms for the graphical interface)*

## 🌐 How It Works

1. Launch the flight simulator on a host machine (must support remote control via network).
2. Start the Remote Flight Controller app and input:

   * **Simulator IP address**
   * **Port number**
3. Establish a network connection.
4. Begin sending control commands to the simulator and receive feedback in real-time.


## 📚 Learning Outcomes

* Network programming in C# using TCP/UDP sockets
* Real-time command handling and data exchange
* Building responsive control interfaces for simulators
