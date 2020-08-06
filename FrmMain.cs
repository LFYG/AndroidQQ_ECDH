using System;
using System.Windows.Forms;

namespace AndroidQQ_8_4_1_4680_ECDH
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnClientGenKeys_Click(object sender, EventArgs e)
        {
            EcdhCrypt ecdh = new EcdhCrypt();
            ecdh.GenEcdhKeys();
            txtClientPubkey.Text = ecdh.GetPublicKeyHex();
            txtClientPrikey.Text = ecdh.GetPrivateKeyHex();
        }

        private void BtnServerGenKeys_Click(object sender, EventArgs e)
        {
            EcdhCrypt ecdh = new EcdhCrypt();
            ecdh.GenEcdhKeys();
            txtServerPubkey.Text = ecdh.GetPublicKeyHex();
            txtServerPrikey.Text = ecdh.GetPrivateKeyHex();
        }

        private void BtnExchangePubkey_Click(object sender, EventArgs e)
        {
            string clientPubkey = txtClientPubkey.Text;
            txtClientPubkey.Text = txtServerPubkey.Text;
            txtServerPubkey.Text = clientPubkey;
        }

        private void BtnClientGenShakey_Click(object sender, EventArgs e)
        {
            EcdhCrypt ecdh = new EcdhCrypt();
            txtClientShakey.Text = ecdh.GenShareKeyHex(txtClientPubkey.Text.ToBytes(), txtClientPrikey.Text.ToBytes());
        }

        private void BtnServerGenShakey_Click(object sender, EventArgs e)
        {
            EcdhCrypt ecdh = new EcdhCrypt();
            txtServerShakey.Text = ecdh.GenShareKeyHex(txtServerPubkey.Text.ToBytes(), txtServerPrikey.Text.ToBytes());
        }
    }
}
