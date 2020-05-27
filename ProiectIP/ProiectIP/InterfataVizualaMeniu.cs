/**************************************************************************
 *                                                                        *
 *  File:        Interfata.cs                                             *
 *  Copyright:   (c) 2020                                                 *
 *  Website:     https://github.com/popirdamihaivalentin/IP-Project       *
 *  Description: Permite instantierea mai multor camere de chat si        *
 *   conectarea mai multor utilizatori in camere cu ajutorul codului      *
 *   camerei                                                              * 
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP
{
    public partial class InterfataVizualaMeniu : Form
    {
        #region Fields
        Dictionary<string, Chatroom> _vectorChatroom = new Dictionary<string, Chatroom>();
        #endregion

        #region PublicFunctions
        public InterfataVizualaMeniu()
        {

            InitializeComponent();

        }
        #endregion


        #region PrivateFunctions
        public void buttonAdaugaCamera_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBoxNumarCameraAdaugaCamera.TextLength == 0)
                {
                    MessageBox.Show("Numele camerei nu poate sa fie gol");
                }
                else if (!_vectorChatroom.ContainsKey(textBoxNumarCameraAdaugaCamera.Text))
                {
                    _vectorChatroom[textBoxNumarCameraAdaugaCamera.Text] = new Chatroom();
                    textBoxNumarCameraAdaugaCamera.Clear();
                }
                else
                {
                    throw new Exception();
                }
            } catch (Exception)
            {
                MessageBox.Show("Camera de chat " + textBoxNumarCameraAdaugaCamera.Text + " exista deja");
            }

        }

        public void buttonAdaugaUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_vectorChatroom.ContainsKey(textBoxNumarCameraAdaugaUser.Text))
                {
                    System.Windows.Forms.MessageBox.Show("Camera de chat nu exista inca");
                }

                else if (textBoxNumeUser.TextLength == 0)
                {
                    MessageBox.Show("Introduceti numele user-ului");
                }
                else if (!_vectorChatroom[textBoxNumarCameraAdaugaUser.Text].ExistaParticipant(textBoxNumeUser.Text) )
                {
                    Participant aux = new Participant(textBoxNumeUser.Text, textBoxNumarCameraAdaugaUser.Text);
                    _vectorChatroom[textBoxNumarCameraAdaugaUser.Text].InregistreazaParticipant(aux);
                    textBoxNumarCameraAdaugaUser.Clear();
                    textBoxNumeUser.Clear();
                } else
                {
                    throw new Exception();
                }
            } catch
            {
                System.Windows.Forms.MessageBox.Show("Utilizatorul exista deja in camera de chat");
            }
        }

        public void buttonHelp_Click(object sender, EventArgs e)
        {
            Process myProc = new Process();
            myProc.StartInfo.FileName = "D:\\Facultate\\Sem II Anul 3\\IP\\ProiectIP\\ProiectIP\\Help-proiect-IP.chm";
            myProc.StartInfo.CreateNoWindow = true;
            myProc.Start();

        }
    }
       #endregion
}
