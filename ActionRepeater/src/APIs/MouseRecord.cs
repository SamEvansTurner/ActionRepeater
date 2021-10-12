using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Input;

namespace ActionRepeater {
    class MouseRecord {
        public struct MouseEvent {
            public int x;
            public int y;
            public int delta;
            public ActionEvent.MouseButton mb;

            public MouseEvent(int inX, int inY, ActionEvent.MouseButton inMb, int inDelta = -1) {
                x = inX;
                y = inY;
                delta = inDelta;
                mb = inMb;
            }
        }

        private static int WH_MOUSE_LL = 14;
        private static IntPtr hook = IntPtr.Zero;
        private static InputImports.LowLevelHookProc llmProcedure = HookCallback;
        private static bool bRecording = false;
        private static MouseRecordEvent callback = null;
        private static List<MouseEvent> mbEvents = new List<MouseEvent>();
        private static Stopwatch stopwatch = new Stopwatch();

        public delegate void MouseRecordEvent(MouseEvent evt, int time);

        public static List<MouseEvent> Events {
            get { return mbEvents; }
        }

        public static bool Recording {
            get { return bRecording; }
        }

        public static void ClearEvents() {
            mbEvents.Clear();
        }

        public static void StartStopRecording(bool keepEvents = false) {
            if (hook == IntPtr.Zero) {
                hook = SetHook();
                bRecording = true;
                if (!keepEvents) {
                    mbEvents.Clear();
                }
                stopwatch.Start();
            } else {
                InputImports.UnhookWindowsHookEx(hook);
                hook = IntPtr.Zero;
                bRecording = false;
                stopwatch.Reset();
            }
        }

        public static void SetCallBack(MouseRecordEvent callbackIn) {
            callback = callbackIn;
        }

        public static IntPtr SetHook() {
            Process currentProcess = Process.GetCurrentProcess();
            ProcessModule currentModule = currentProcess.MainModule;
            String moduleName = currentModule.ModuleName;
            IntPtr moduleHandle = InputImports.GetModuleHandle(moduleName);
            return InputImports.SetWindowsHookEx(WH_MOUSE_LL, llmProcedure, moduleHandle, 0);
        }

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {

            if (nCode >= 0) {
                if (wParam == (IntPtr)ActionEvent.MouseButton.Left || wParam == (IntPtr)ActionEvent.MouseButton.Right) {
                    InputImports.MSLLHOOKSTRUCT hookStruct = (InputImports.MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(InputImports.MSLLHOOKSTRUCT));
                    MouseEvent mEv = new MouseEvent(hookStruct.pt.x, hookStruct.pt.y, (ActionEvent.MouseButton)wParam);
                    callback?.Invoke(mEv, hookStruct.time);
                    mbEvents.Add(mEv);
                } else if (wParam == (IntPtr)ActionEvent.MouseButton.Wheel) {
                    InputImports.MSLLHOOKSTRUCT hookStruct = (InputImports.MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(InputImports.MSLLHOOKSTRUCT));
                    int zDelta = (int)(hookStruct.mouseData & (0xFFFF0000)) >> 16;
                    MouseEvent mEv = new MouseEvent(hookStruct.pt.x, hookStruct.pt.y, (ActionEvent.MouseButton)wParam, zDelta);
                    if((Control.ModifierKeys & Keys.Shift) == Keys.Shift) {
                        mEv.mb = ActionEvent.MouseButton.ControlWheel;
                    }
                    callback?.Invoke(mEv, hookStruct.time);
                    mbEvents.Add(mEv);
                } else if (wParam == (IntPtr)ActionEvent.MouseButton.Move && stopwatch.ElapsedMilliseconds > 500) {
                    InputImports.MSLLHOOKSTRUCT hookStruct = (InputImports.MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(InputImports.MSLLHOOKSTRUCT));
                    MouseEvent mEv = new MouseEvent(hookStruct.pt.x, hookStruct.pt.y, ActionEvent.MouseButton.Move);
                    callback?.Invoke(mEv, hookStruct.time);
                    mbEvents.Add(mEv);
                }
                stopwatch.Restart();
            }


            return InputImports.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }


    }


}
