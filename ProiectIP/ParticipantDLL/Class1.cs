using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Participant

{
    #region Fields
     private IChatroom _chatroom;
    private string _numeParticipant;
    // public InterfataVizualaCamera _camera;
    #endregion


    #region Constructors
    public Participant(string _numeParticipant, string _numeCamera)
    {
        this._numeParticipant = _numeParticipant;
        // this._camera = new InterfataVizualaCamera(_numeCamera, _numeParticipant);
        //  this._camera._participant = this;
    }

    public string NumeParticipant
    {
        get { return _numeParticipant; }
    }


    public IChatroom Chatroom
    {
        set { _chatroom = value; }
        get { return _chatroom; }
    }
    #endregion

    #region PublicFunctions
    /*  public void ShowCamera()
      {
          _camera.Show();
      }*/

      public void TrimiteMesaj(string mesaj)
      {
          _chatroom.TrimiteMesaj(mesaj);
      }

     /* public void PrimesteMesaj(string mesaj)
      {
          _camera.AfiseazaMesaj(mesaj);
      }*/
      /*
      public void TrimiteUtilizatori(string stringParticipanti)
      {
          _camera.PrimesteParticipanti(stringParticipanti);
      }*/

      public void Deconectare()
      {
          _chatroom.Deconectare(this);
      }

  
}
    #endregion
