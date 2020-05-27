using System;
/**************************************************************************
 *                                                                        *
 *  File:        Camera.cs                                                *
 *  Copyright:   (c) 2020                                                 *
 *  Website:     https://github.com/popirdamihaivalentin/IP-Project       *
 *  Description: constituie interfata cu utilizatorii care sunt conectati *
 *   in camerele de chatroom, permite vizualizarea utilizatorilor         *
 *   conectati, numele camerei, mesajele trimise in ordine cronologica si *
 *    permite trimiterea de mesaje.                                       *                            
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

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
     public partial class InterfataVizualaCamera : Form
    {
        #region Fields
        public Participant _participant;
        #endregion

        #region PublicFunctions
        public InterfataVizualaCamera(string numarCamera,string numeParticipant)
        {  

            InitializeComponent();
            textBoxNumarCamera.Text = numarCamera;
            textBoxNumeUtilizator.Text = numeParticipant;

        }
        public void buttonTrimite_Click(object sender, EventArgs e)
        {
            try
            {
                _participant.TrimiteMesaj(textBoxNumeUtilizator.Text + ":" + textBoxBuffer.Text);
                textBoxBuffer.Clear();
            } catch (Exception exc)
            {
                throw exc;
            }
           

        }

        public void AfiseazaMesaj(string mesaj)
        {

            textBoxConversatie.Text += mesaj + "\r\n" ;

        }

        public void buttonHelp_Click(object sender, EventArgs e)
        {

            Process myProc = new Process();
            myProc.StartInfo.FileName = "D:\\Facultate\\Sem II Anul 3\\IP\\ProiectIP\\ProiectIP\\Help-proiect-IP.chm";
            myProc.StartInfo.CreateNoWindow = true;
            myProc.Start();

        }

        public void PrimesteParticipanti(string stringParticipanti)
        {

            textBoxParticipanti.Text = stringParticipanti;

        }
        #endregion

        #region ProtectedFunctions
        protected override void OnClosed(EventArgs e)
        {

            _participant.Deconectare();
            base.OnClosed(e); 

        }
        #endregion
    }
}
