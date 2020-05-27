using System;
/**************************************************************************
 *                                                                        *
 *  File:        UnitTest1.cs                                             *
 *  Copyright:   (c) 2020                                                 *
 *  Website:     https://github.com/popirdamihaivalentin/IP-Project       *
 *  Description: constituie unit testing pentru clasele programului       *                            
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProiectIP;
using System.Windows.Forms;

namespace UnitTestChat
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void ButonAdaugaCamera()
        {
            InterfataVizualaMeniu meniu = new InterfataVizualaMeniu();
            Assert.AreEqual(DialogResult.None, meniu.buttonAdaugaCamera.DialogResult);
        }

        [TestMethod]
        public void ButonAdaugaUser()
        {
            InterfataVizualaMeniu meniu = new InterfataVizualaMeniu();
            Assert.AreEqual(DialogResult.None, meniu.buttonAdaugaUser.DialogResult);
        }

        [TestMethod]
        public void buttonHelp()
        {
            InterfataVizualaMeniu meniu = new InterfataVizualaMeniu();
            Assert.AreEqual(DialogResult.None, meniu.buttonHelp.DialogResult);
        }


        //test pentru a verifica ca un user s-a inregistrat cu success
        [TestMethod]
        public void existaParticipant()
        {
            Chatroom chatroom = new Chatroom();
            Participant participant = new Participant("Ionel", "123");

            chatroom.InregistreazaParticipant(participant);

            Assert.IsTrue(chatroom.ExistaParticipant("Ionel"));
        }

        //throws NullRefference error when only textBoxNumarCamera is completed
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullRefferenceExceptionViewCamera()
        {
            InterfataVizualaCamera interfataCamera = new InterfataVizualaCamera("123", "Valentin");
            interfataCamera.textBoxNumarCamera.AppendText("123");
            interfataCamera.buttonTrimite_Click(interfataCamera, EventArgs.Empty);
        }

        //throws NullRefference error when only textBoxBuffer is completed
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullRefferenceExceptionViewCamera2()
        {
            InterfataVizualaCamera interfataCamera = new InterfataVizualaCamera("123", "Valentin");
            interfataCamera.textBoxBuffer.AppendText("123");
            interfataCamera.buttonTrimite_Click(interfataCamera, EventArgs.Empty);
        }

        //throws NullRefference error when only textBoxConversatie is completed
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullRefferenceExceptionViewCamera3()
        {
            InterfataVizualaCamera interfataCamera = new InterfataVizualaCamera("123", "Valentin");
            interfataCamera.textBoxConversatie.AppendText("123");
            interfataCamera.buttonTrimite_Click(interfataCamera, EventArgs.Empty);
        }

        //throws NullRefference error when only textBoxNumeUtilizator is completed
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullRefferenceExceptionViewCamera4()
        {
            InterfataVizualaCamera interfataCamera = new InterfataVizualaCamera("123", "Valentin");
            interfataCamera.textBoxNumeUtilizator.AppendText("123");
            interfataCamera.buttonTrimite_Click(interfataCamera, EventArgs.Empty);
        }

        //throws NullRefference error when only textBoxParticipanti is completed
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullRefferenceExceptionViewCamera5()
        {
            InterfataVizualaCamera interfataCamera = new InterfataVizualaCamera("123", "Valentin");
            interfataCamera.textBoxParticipanti.AppendText("123");
            interfataCamera.buttonTrimite_Click(interfataCamera, EventArgs.Empty);
        }


        //test pentru a verifica ca un user nu este inregistrat
        [TestMethod]
        public void participantInexistent()
        {
            Chatroom chatroom = new Chatroom();
            Assert.IsFalse(chatroom.ExistaParticipant("Ionel"));
        }

        //test pentru a verifica ca un user s-a deconectat
        [TestMethod]
        public void participantDeconectat()
        {
            Chatroom chatroom = new Chatroom();
            Participant participant = new Participant("Ionel", "123");
            chatroom.InregistreazaParticipant(participant);
            chatroom.Deconectare(participant);
            Assert.IsFalse(chatroom.ExistaParticipant("Ionel"));
        }

        //test pentru a verifica ca doar un user nu s-a deconectat
        [TestMethod]
        public void participantStillConectat()
        {
            Chatroom chatroom = new Chatroom();
            Participant participant = new Participant("Ionel", "123");
            Participant participant2 = new Participant("Petrica", "123");
            
            chatroom.InregistreazaParticipant(participant);
            chatroom.InregistreazaParticipant(participant2);
            chatroom.Deconectare(participant2);
            
            Assert.IsTrue(chatroom.ExistaParticipant("Ionel"));
            Assert.IsFalse(chatroom.ExistaParticipant("Petrica"));

        } 

        //test pentru a verifica ca textInput camera e cleared dupa creare
        [TestMethod]
        public void clearTextBoxCamera()
        {
            InterfataVizualaMeniu meniu = new InterfataVizualaMeniu();
            meniu.InitializeComponent();

            meniu.textBoxNumarCameraAdaugaCamera.AppendText("333");
            meniu.buttonAdaugaCamera_Click(meniu, EventArgs.Empty);
            
            Assert.AreEqual("", meniu.textBoxNumarCameraAdaugaCamera.Text);
        }

        /*[TestMethod]
        public void clearTextBoxCameraNotWorking()
        {
            InterfataVizualaMeniu meniu = new InterfataVizualaMeniu();
            meniu.InitializeComponent();

            meniu.textBoxNumarCameraAdaugaCamera.AppendText("333");
            meniu.buttonAdaugaCamera_Click(meniu, EventArgs.Empty);
            meniu.textBoxNumarCameraAdaugaCamera.AppendText("333");
            meniu.buttonAdaugaCamera_Click(meniu, EventArgs.Empty);
            SendKeys.Send("{ENTER}");

            Assert.AreEqual("333", meniu.textBoxNumarCameraAdaugaCamera.Text);
        }*/

        //check clear la inputs UserName si NrCamera cand au fost create cu success
        [TestMethod]
        public void clearTextBoxCameraSiUserSuccess()
        {
            InterfataVizualaMeniu meniu = new InterfataVizualaMeniu();
            meniu.InitializeComponent();

            //creaza camera
            meniu.textBoxNumarCameraAdaugaCamera.AppendText("333");
            meniu.buttonAdaugaCamera_Click(meniu, EventArgs.Empty);

            //adauga User la camera
            meniu.textBoxNumarCameraAdaugaUser.AppendText("333");
            meniu.textBoxNumeUser.AppendText("Valentin");
            meniu.buttonAdaugaUser_Click(meniu, EventArgs.Empty);
            Assert.AreEqual("", meniu.textBoxNumarCameraAdaugaUser.Text);
            Assert.AreEqual("", meniu.textBoxNumeUser.Text);
        }

        [TestMethod]
        public void butonTrimiteMesaj()
        {
            InterfataVizualaCamera camera = new InterfataVizualaCamera("333", "Valentin");

            Assert.AreEqual(DialogResult.None, camera.buttonTrimite.DialogResult);
        }

        [TestMethod]
        public void butonCameraHelp()
        {
            InterfataVizualaCamera camera = new InterfataVizualaCamera("333", "Valentin");

            Assert.AreEqual(DialogResult.None, camera.buttonHelp.DialogResult);
        }

        //validate text inputs are enabled on new created camera
        [TestMethod]
        public void validateTextInputsAreEnabledOnCamera()
        {
            InterfataVizualaCamera camera = new InterfataVizualaCamera("333", "Valentin");

            Assert.IsTrue(camera.textBoxBuffer.Enabled);
            Assert.IsTrue(camera.textBoxConversatie.Enabled);
            Assert.IsTrue(camera.textBoxNumarCamera.Enabled);
            Assert.IsTrue(camera.textBoxNumeUtilizator.Enabled);
            Assert.IsTrue(camera.textBoxParticipanti.Enabled);
        }

        //validate buttons are enabled on new created camera
        [TestMethod]
        public void validateButtonsAreEnabledOnCamera()
        {
            InterfataVizualaCamera camera = new InterfataVizualaCamera("333", "Valentin");
            
            Assert.IsTrue(camera.buttonHelp.Enabled);
            Assert.IsTrue(camera.buttonTrimite.Enabled);
        }

        //validate buttons are enabled on new meniu
        [TestMethod]
        public void validateButtonsAreEnabledOnMeniu()
        {
            InterfataVizualaMeniu meniu = new InterfataVizualaMeniu();

            Assert.IsTrue(meniu.buttonAdaugaCamera.Enabled);
            Assert.IsTrue(meniu.buttonAdaugaUser.Enabled);
        }

        //validate text inputs are enabled on new meniu
        [TestMethod]
        public void validateInputsAreEnabledOnMeniu()
        {
            InterfataVizualaMeniu meniu = new InterfataVizualaMeniu();

            Assert.IsTrue(meniu.textBoxNumarCameraAdaugaCamera.Enabled);
            Assert.IsTrue(meniu.textBoxNumarCameraAdaugaUser.Enabled);
            Assert.IsTrue(meniu.textBoxNumeUser.Enabled);
        }
    }
}
