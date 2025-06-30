# WebView2FreezePOC

This repository contains a minimal UWP proof-of-concept demonstrating a freeze issue with the WebView2 control, as reported in [MicrosoftEdge/WebView2Feedback#5284](https://github.com/MicrosoftEdge/WebView2Feedback/issues/5284).

## ❗ Issue Summary

This POC highlights a WebView2-specific freeze scenario observed under normal editing interactions inside the control. The freeze is occurs when the system is set to Best power efficiency mode, with the charger unplugged. Content length doesn't have to be large - the issue still occurs with minimal content in the editable body.


## 🚀 How to Run the POC

1. Clone this repository:
   ```bash
   git clone https://github.com/Aishwarya-Jeyaraj/WebView2FreezePOC.git
   
2. Open the solution in Visual Studio 2022 (with UWP and WebView2 support installed).

3. Set WebView2FreezePOC as the startup project.

4. Build and run the application.


## 🧪 How to Reproduce the Freeze

Run the app and interact with WebView2 repeatedly:

 - Select a few words or lines and press Ctrl + C or Ctrl + A

 - Scroll down, then scroll back to the top

 - Try typing in the editor

Observe: The app freezes temporarily — keystrokes do not appear for a few seconds, and the UI becomes unresponsive.
