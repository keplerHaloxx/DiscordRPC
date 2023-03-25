using System;
using System.Windows.Forms;
using Siticone.UI.WinForms;
using DiscordRPC;
using DiscordRPC.Logging;
using Button = DiscordRPC.Button;
using DiscordRPC.Helper;

namespace DRPC
{
    public partial class MainForm : Form
    {
        private DiscordRpcClient client;

        public MainForm()
        {
            InitializeComponent();

            #region Init
            SiticoneElipse psize1 = new SiticoneElipse() { TargetControl = PartySize1, BorderRadius = 4 };
            SiticoneElipse psize2 = new SiticoneElipse() { TargetControl = PartySize2, BorderRadius = 4 };

            trayIcon.ContextMenu = new ContextMenu(new MenuItem[]
            {
                new MenuItem("Exit", TrayClose)
            });
            #endregion

        }

        #region Useless Stuff
        void TrayClose(object sender, EventArgs e)
        {
            trayIcon.Visible = false;
            Application.Exit();
        }

        private void MinimizeImageButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseImageButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void trayIcon_Click(object sender, EventArgs e)
        {
            Show();
        }

        #endregion

        private void ActivateButton_Click(object sender, EventArgs e)
        {
            // Check if party size is valid
            if (PartySize2.Value < PartySize1.Value) { MessageBox.Show("Party size cannot be lower than the current party amount", "Error"); return; }
            
            client?.ClearPresence();
            
            // If party size is 0:0 then it will show 1:1. This fixes that
            if (PartySize1.Value == 0 && PartySize2.Value == 0)
                client.SetPresence(new RichPresence
                {
                    Details = DetailsTBox.Text.GetNullOrString(),
                    State = StateTBox.Text.GetNullOrString(),
                    Assets = new Assets()
                    {
                        LargeImageKey = LImgTBox.Text.GetNullOrString(),
                        LargeImageText = LImgTextTBox.Text.GetNullOrString(),
                        SmallImageKey = SImgTBox.Text.GetNullOrString(),
                        SmallImageText = SImgTextTBox.Text.GetNullOrString()
                    },
                });
            else
                client.SetPresence(new RichPresence
                {
                    Details = DetailsTBox.Text.GetNullOrString(),
                    State = StateTBox.Text.GetNullOrString(),
                    Assets = new Assets()
                    {
                        LargeImageKey = LImgTBox.Text.GetNullOrString(),
                        LargeImageText = LImgTextTBox.Text.GetNullOrString(),
                        SmallImageKey = SImgTBox.Text.GetNullOrString(),
                        SmallImageText = SImgTextTBox.Text.GetNullOrString()
                    },
                    Party = new Party { Size = (int)PartySize1.Value, Max = (int)PartySize2.Value, ID = "ID" },
                });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Dispose();
        }

        private void InjectButton_Click(object sender, EventArgs e)
        {
            // Dispose of client if it exists, then initialize new AppID
            if (client != null && client.IsInitialized) client.Dispose();
            client = new DiscordRpcClient(AppIdTBox.Text);

            client.Initialize();

            ActivateButton.Enabled = true;
        }
    }
}
