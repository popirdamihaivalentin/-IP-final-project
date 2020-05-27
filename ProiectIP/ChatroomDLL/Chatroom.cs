/**************************************************************************
 *                                                                        *
 *  File:        Chatroom.cs                                              *
 *  Copyright:   (c) 2020                                                 *
 *  Website:     https://github.com/popirdamihaivalentin/IP-Project       *
 *  Description: Implementeaza interfata AbstractChatroom definind concret*
 *   functiile de intregistrarea, trimitere de mesaje, deconectare, de    *
 *    asemenea aici se vreifica daca un participant exista deja in o      *
 *     camera de chat.                                                    *    
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Chatroom : IChatroom


{
     private Dictionary<string, Participant> _participanti = new Dictionary<string, Participant>();

    #region PublicFunctions
    public override void InregistreazaParticipant(Participant participant)
     {

         _participanti[participant.NumeParticipant] = participant;
         participant.Chatroom = this;
         //participant.ShowCamera();
         string stringParticipanti = "";

         foreach (var item in _participanti.Keys)
         {
             stringParticipanti += item + "\r\n";
         }

         foreach (var item in _participanti.Keys)
         {
            // _participanti[item].TrimiteUtilizatori(stringParticipanti);
         }

     }

     public bool ExistaParticipant(string numeParticipant)
     {

         foreach (var item in _participanti.Keys)
         {
             if (item == numeParticipant)
                 return true;
         }
         return false;

     }

     public override void TrimiteMesaj(string mesaj)
     {

         Participant participant;
         foreach (var item in _participanti.Keys)
         {
             participant = _participanti[item];
            // participant.PrimesteMesaj(mesaj);
         }

     }

     public override void Deconectare(Participant participant)
     {

         _participanti.Remove(participant.NumeParticipant);
         string stringParticipanti = "";

         foreach (var item in _participanti.Keys)
         {
             stringParticipanti += item + "\r\n";
         }

         foreach (var item in _participanti.Keys)
         {
            // _participanti[item].TrimiteUtilizatori(stringParticipanti);
         }

     }


 
    #endregion
}
