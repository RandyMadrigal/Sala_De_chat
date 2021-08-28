using System;
using System.Drawing;
using System.Windows.Forms;

namespace SalaChat
{
    public partial class Form1 : Form
    {
        string mensaje = "Enviado por Randy Madrigal / 2019-8915";

        public Form1()
        {
            InitializeComponent();
            
            DiseñoBotones();
        }

        public void DiseñoBotones()
        {
            //Formulario
            this.Text = "Chat-2019-8915";
            this.Icon = new Icon(@"Imagen\chat.ico");

            //Botones
            BtnEnviar.Image = Image.FromFile(@"Imagen/send.png");
            btnMic.Image = Image.FromFile(@"Imagen/Mic.png");
            emoji.Image = Image.FromFile(@"Imagen/smiling.png");
            btnGif.Image = Image.FromFile(@"Imagen/gif.png");
            btnCloseChat.Image = Image.FromFile(@"Imagen/close.png");

            //Contactos
            pictureBox.Image  = Image.FromFile(@"Imagen/BOOK.gif");
            btnprofile1.Image = Image.FromFile(@"Imagen/man.gif");
            btnprofile2.Image = Image.FromFile(@"Imagen/women.gif");
            btnprofile3.Image = Image.FromFile(@"Imagen/women.gif");
            btnprofile4.Image = Image.FromFile(@"Imagen/women.gif");
            btnprofile5.Image = Image.FromFile(@"Imagen/Man.gif");
            btnprofile6.Image = Image.FromFile(@"Imagen/Man.gif");
            btnprofile7.Image = Image.FromFile(@"Imagen/Man.gif");
            btnprofile8.Image = Image.FromFile(@"Imagen/Man.gif");
            btnprofile9.Image = Image.FromFile(@"Imagen/women.gif");
            btnprofile10.Image = Image.FromFile(@"Imagen/women.gif");
            btnprofile11.Image = Image.FromFile(@"Imagen/Plus.gif");

            //Imagen chat
            newChatPicture.Image = Image.FromFile(@"Imagen/new chat.gif");
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            DateTime tiempo = DateTime.Now;

            boxChat.Text += Environment.NewLine + BoxEnviar.Text + Environment.NewLine + mensaje +" Hora: "+tiempo.ToString("hh:mm tt")+" "+Environment.NewLine;
            
            BoxEnviar.Clear();
        }

        private void NewChat(object sender, EventArgs e)
        {
            var Boton = ((Button)sender);
            boxChat.Clear();
            newChatPicture.Visible = false;

            IniciarChat("\t\tNuevo chat --> "+Boton.Text+ Environment.NewLine );

        }

        private void IniciarChat(string texto)
        {
            string NombreChat = texto;

            boxChat.Text = NombreChat;

        }

        private void btnCloseChat_Click(object sender, EventArgs e)
        {
            newChatPicture.Visible = true;
        }
    }
}
