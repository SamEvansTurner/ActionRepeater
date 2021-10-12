using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ActionRepeater {
    class KeyRecord {

        private static int WH_KEYBOARD_LL = 13;
        private static int WM_KEYDOWN = 0x0100;
        private static IntPtr hook = IntPtr.Zero;
        private static InputImports.LowLevelHookProc llkProcedure = HookCallback;
        private static List<Keys> keysPressed = new List<Keys>();
        private static bool bRecording = false;

        public delegate void KeyRecordEvent(InputImports.VirtualKeyShort keyPressed, int time);

        private static KeyRecordEvent callback = null;

        public static List<Keys> Events {
            get { return keysPressed; }
        }

        public static bool Recording {
            get { return bRecording; }
        }

        public static void ClearEvents() {
            keysPressed.Clear();
        }

        public static void SetCallBack(KeyRecordEvent inCallback) {
            callback = inCallback;
        }

        public static void StartStopRecording(bool keepEvents = false) {
            if (hook == IntPtr.Zero) {
                hook = SetHook();
                bRecording = true;
                if (!keepEvents) {
                    keysPressed.Clear();
                }

            } else {
                InputImports.UnhookWindowsHookEx(hook);
                hook = IntPtr.Zero;
                bRecording = false;
            }
        }

        public static IntPtr SetHook() {
            Process currentProcess = Process.GetCurrentProcess();
            ProcessModule currentModule = currentProcess.MainModule;
            String moduleName = currentModule.ModuleName;
            IntPtr moduleHandle = InputImports.GetModuleHandle(moduleName);
            return InputImports.SetWindowsHookEx(WH_KEYBOARD_LL, llkProcedure, moduleHandle, 0);
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN) {
                InputImports.KBDLLHOOKSTRUCT hookStruct = (InputImports.KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(InputImports.KBDLLHOOKSTRUCT));
                InputImports.VirtualKeyShort kc = (InputImports.VirtualKeyShort)hookStruct.vkCode;
                if(kc != InputImports.VirtualKeyShort.LSHIFT && kc != InputImports.VirtualKeyShort.LCONTROL) {
                    keysPressed.Add((Keys)hookStruct.vkCode);
                    callback?.Invoke(kc, hookStruct.time);
                }
                
            }

            return InputImports.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }


    }


}
