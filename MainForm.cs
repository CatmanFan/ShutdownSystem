using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ShutdownSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            Text = Application.ProductName;

            Array List = Enum.GetValues(typeof(Commands.NtStatus));
            foreach (var item in List)
                NtStatus.Items.Add(item.ToString());

            string Warning = "The shutdown methods in this section have a potential to cause\nDATA CORRUPTION AND/OR LOSS, and must be handled with caution.";
            WarningToolTip.SetToolTip(WarningIcon1, Warning);
            WarningToolTip.SetToolTip(WarningIcon2, Warning);
        }

        private void ExitWindowsEx_Button_Click(object sender, EventArgs e) => ExitWindowsEx.Show(Cursor.Position.X, Cursor.Position.Y);

        private void ExitWindowsEx_Sh_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ShutdownPrivilege(); Commands.ExitWindowsEx(Commands.ExitWindows.ShutDown); });
        private void ExitWindowsEx_Off_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ShutdownPrivilege(); Commands.ExitWindowsEx(Commands.ExitWindows.PowerOff); });
        private void ExitWindowsEx_Re_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ShutdownPrivilege(); Commands.ExitWindowsEx(Commands.ExitWindows.Reboot); });
        private void ExitWindowsEx_Lo_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ExitWindowsEx(Commands.ExitWindows.LogOff); });
        private void ExitWindowsEx_Ra_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ExitWindowsEx(Commands.ExitWindows.RestartApps); });


        private void InitiateSystemShutdownEx_Button_Click(object sender, EventArgs e) => InitiateSystemShutdownEx.Show(Cursor.Position.X, Cursor.Position.Y);

        private void InitiateSystemShutdownEx_N_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.InitiateSystemShutdownEx("", "Shutting down upon request from software", 0, false, false, Commands.ShutdownReason.MinorOther); });
        private void InitiateSystemShutdownEx_NF_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.InitiateSystemShutdownEx("", "Shutting down upon request from software", 0, true, false, Commands.ShutdownReason.MinorOther); });
        private void InitiateSystemShutdownEx_R_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.InitiateSystemShutdownEx("", "Restarting upon request from software", 0, false, true, Commands.ShutdownReason.MinorOther); });
        private void InitiateSystemShutdownEx_RF_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.InitiateSystemShutdownEx("", "Restarting upon request from software", 0, true, true, Commands.ShutdownReason.MinorOther); });


        private void NtShutdownSystem_Button_Click(object sender, EventArgs e) => NtShutdownSystem.Show(Cursor.Position.X, Cursor.Position.Y);

        private void NtShutdownSystem_H_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ShutdownPrivilege(); Commands.NtShutdownSystem(Commands.ShutdownAction.ShutdownNoReboot); });
        private void NtShutdownSystem_R_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ShutdownPrivilege(); Commands.NtShutdownSystem(Commands.ShutdownAction.ShutdownReboot); });
        private void NtShutdownSystem_P_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ShutdownPrivilege(); Commands.NtShutdownSystem(Commands.ShutdownAction.ShutdownPowerOff); });


        private void NtSetSystemPowerState_Button_Click(object sender, EventArgs e) => NtSetSystemPowerState.Show(Cursor.Position.X, Cursor.Position.Y);

        private void NtSetSystemPowerState_H_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ShutdownPrivilege(); Commands.NtSetSystemPowerState(Commands.PowerAction.PowerActionShutdown, Commands.SystemPowerState.PowerSystemUnspecified); });
        private void NtSetSystemPowerState_R_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ShutdownPrivilege(); Commands.NtSetSystemPowerState(Commands.PowerAction.PowerActionShutdownReset, Commands.SystemPowerState.PowerSystemUnspecified); });
        private void NtSetSystemPowerState_P_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.ShutdownPrivilege(); Commands.NtSetSystemPowerState(Commands.PowerAction.PowerActionShutdownOff, Commands.SystemPowerState.PowerSystemShutdown); });


        private void SetSystemPowerState_Button_Click(object sender, EventArgs e) => SetSystemPowerState.Show(Cursor.Position.X, Cursor.Position.Y);

        private void SetSystemPowerState_Y_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.SetSystemPowerState(null, 0x00010000, 4096); });
        private void SetSystemPowerState_N_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.SetSystemPowerState(null, 0x00020000, 4096); });
        private void SetSystemPowerState_S_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.SetSystemPowerState(null, 0x00200000, 4096); });
        private void SetSystemPowerState_R_Click(object sender, EventArgs e) => Task.Factory.StartNew(() => { Commands.SetSystemPowerState(null, 0x00800000, 4096); });


        private void NtRaiseHardError_Click(object sender, EventArgs e) => Task.Factory.StartNew(() =>
        {
            Commands.ShutdownPrivilege();
            Commands.NtStatus status;
            if (Enum.TryParse(NtStatus.SelectedItem.ToString(), true, out status))
                Task.Factory.StartNew(() => { Commands.NtRaiseHardError(status, 0, 0, IntPtr.Zero, 6, out uint Response); });
        });

        private void NtSetInformationProcess_CheckedChanged(object sender, EventArgs e)
        {
            Commands.IsCritical(NtSetInformationProcess.Checked);
            if (NtSetInformationProcess.Checked) label2.Text = "Critical"; else label2.Text = "Normal";
            if (NtSetInformationProcess.Checked) label2.ForeColor = Color.Firebrick; else label2.ForeColor = Color.SteelBlue;
        }

        private void NtStatus_SelectedIndexChanged(object sender, EventArgs e) => NtRaiseHardError.Enabled = NtStatus.SelectedIndex >= 0;

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{Application.ProductName} v{Application.ProductVersion}\n© CatmanFan / Mr._Lechkar 2023", About.Text);
        }
    }
}
