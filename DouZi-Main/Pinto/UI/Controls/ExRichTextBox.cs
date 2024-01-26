using PintoNS.Forms;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PintoNS.UI.Controls
{
    public class ExRichTextBox : RichTextBox
    {
        private const int EM_SETOLECALLBACK = 1076;

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr LoadLibrary(string library);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams createParams = base.CreateParams;

                if (!Program.RunningUnderMono)
                {
                    try
                    {
                        LoadLibrary("MsftEdit.dll");

                        SendMessage(Handle, EM_SETOLECALLBACK, IntPtr.Zero, IntPtr.Zero);

                    }
                    catch (Exception ex)
                    {
                        FatalErrorForm fatalErrorForm = new FatalErrorForm();
                        fatalErrorForm.rtxtLog.Text = $"{ex}";
                        fatalErrorForm.ShowDialog();
                        Environment.Exit(0);
                    }
                }

                return createParams;
            }
        }
    }
}
