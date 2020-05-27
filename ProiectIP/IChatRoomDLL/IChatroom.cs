/**************************************************************************
 *                                                                        *
 *  File:        AbstractChatroom.cs                                      *
 *  Copyright:   (c) 2020                                                 *
 *  Website:     https://github.com/popirdamihaivalentin/IP-Project       *
 *  Description: Interfateaza o clasa chatroom permitand inregistrarea,   *
 *   trimiterea de mesaje si deconectarea                                 *                            
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

    public abstract class IChatroom

    {
        #region PublicFunctions
        public abstract void InregistreazaParticipant(Participant participant);
        public abstract void TrimiteMesaj(string mesaj);
        public abstract void Deconectare(Participant participant);
        #endregion
    }



