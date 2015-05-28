using System.Collections.Generic;
using Nwd.BackOffice.Impl;
using Nwd.BackOffice.Model;

namespace WebApplication.Models
{
    public class AlbumViewModels
    {
  
        public IList<Album> AlbumList { get { return Albumrep.GetAllAlbums(); }  }
        public AlbumRepository Albumrep;

        public AlbumViewModels(AlbumRepository Albumrepre)
        {
            Albumrep = Albumrepre;
        }


        
        
        
    }
}